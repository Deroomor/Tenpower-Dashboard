using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace Tenpower.UI.Doc
{
    public class Document : NavController
    {
        [System.ComponentModel.Composition.Import(typeof(IDal.IDevDoc))]
        public IDal.IDevDoc DalDevDoc { get; set; }


        public Azeroth.MVC.ActionResult Add()
        {
            var parameter = this.GetParameterUnvalidated<Model.DevDoc>();
            if (!parameter.Id.Equals(Guid.Empty))
                parameter = DalDevDoc.GetEntity(x=>x.Id, Azeroth.OMT.WH.EQ,parameter.Id).FirstOrDefault()??new Model.DevDoc();
            this.ViewData["doc"] = parameter;
            return View();
        }


        public Azeroth.MVC.ActionResult Save()
        {
            var parameter = this.GetParameterUnvalidated<Model.DevDoc>();
            parameter.DateInfo = DateTime.Now;
            parameter.Author = "wch";
            DalDevDoc.Save(parameter);
            return this.Redirect(string.Format("/Document/Home/Item?Id={0}",parameter.Id));
        }

        public Azeroth.MVC.ActionResult Index()
        {
            List<Model.DevDoc> lst = DalDevDoc.GetEntity();
            ViewData["lstDoc"] = lst;
            return View();
        }

        public Azeroth.MVC.ActionResult Item()
        {
            var parameter= this.GetParameter<Model.DevDoc>();
            Model.DevDoc article = DalDevDoc.GetEntity(x=>x.Id, Azeroth.OMT.WH.EQ,parameter.Id).FirstOrDefault()??new Model.DevDoc();
            this.ViewData["doc"] = article;
            return View();
        }

        /// <summary>
        /// 处理富文本编辑器的文件上传
        /// </summary>
        /// <returns></returns>
        public Azeroth.MVC.ActionResult SaveFile()
        {
            var rst = new { err = string.Empty, msg = new { url = "!http://www.baidu.com/sa.txt", localname = "sa.txt", id = "1" } };
            return this.Json(rst);
        }
    }
}