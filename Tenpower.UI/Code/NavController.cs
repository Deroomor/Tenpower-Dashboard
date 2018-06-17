using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.Composition;
namespace Tenpower.UI
{
    public abstract class NavController:Azeroth.MVC.Controller
    {
        static System.ComponentModel.Composition.Hosting.DirectoryCatalog catalog = 
            new System.ComponentModel.Composition.Hosting.DirectoryCatalog(System.Web.HttpRuntime.BinDirectory);
        public override void OnExecute()
        {
            //权限校验

            //处理菜单
             var lstMenuInfo=   MenuInfoHandler();
             this.ViewData["__menuInfo"] = lstMenuInfo;
            //注入
             System.ComponentModel.Composition.Hosting.CompositionContainer container =
                 new System.ComponentModel.Composition.Hosting.CompositionContainer(catalog);
             container.ComposeParts(this);
        }

        private List<MenuInfo> MenuInfoHandler()
        {
            var lstMenuInfo = MenuInfo.Create();
            lstMenuInfo.ForEach(x=>x.ViewPath=HandlerViewPath(x));
            string url = this.Context.Request.Url.AbsolutePath;
            var lstActive= lstMenuInfo.Where(x=>x.ViewPath.IndexOf(url)>=0).ToList();
            if (lstActive.Count <= 0)
                return new List<MenuInfo>();
            var leaf= lstActive.OrderBy(x => x.Id).Last();//取叶子，这样才能知道菜单的最后一级
            leaf.IsLeaf = true;
            var dict = lstMenuInfo.ToDictionary(x => x.Id, x => x);
            lstMenuInfo.ForEach(x =>
            {
                if (x.Pid > 0)
                {
                    x.Parent = dict[x.Pid];
                    dict[x.Pid].Children.Add(x);
                }
            });
            //取到根
            var root= GetMenuInfoRoot(leaf,lstMenuInfo);
            root.IsRoot = true;
            return lstMenuInfo;
        }

        private string HandlerViewPath(MenuInfo x)
        {
            x.Url = x.Url.ToLower();
            var tmp= x.Url.ToArray().Reverse().ToList();
            tmp.Remove('/');
            tmp.Reverse();
            return string.Concat(tmp);
            
        }

        private MenuInfo GetMenuInfoRoot(MenuInfo menuInfo, List<MenuInfo> lst)
        {
            var tmp= lst.FirstOrDefault(x=>x.Id==menuInfo.Pid);
            if (tmp == null)
                return menuInfo;
            return GetMenuInfoRoot(tmp,lst);
        }

        protected T GetParameterUnvalidated<T>()where T:class,new()
        {
            return new T();
        }

        public override object ResolveRequestParameter(Type type)
        {
            throw new NotImplementedException();
        }
        protected T GetParameter<T>() where T : class,new()
        {
            return new T();
        }
    
        
    }
}