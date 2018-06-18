using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace Tenpower.UI.Doc
{
    public class Document : NavController
    {
        [System.ComponentModel.Composition.Import(typeof(IBll.IAriticle))]
        public IBll.IAriticle BllAriticle { get; set; }


        public Azeroth.Klz.ActionResult Add()
        {
            var parameter = this.GetParameterUnvalidated<Model.DevDoc>();
            if (!parameter.Id.Equals(Guid.Empty))
                parameter = BllAriticle.GetEntityById(parameter.Id);
            this.ViewData["doc"] = parameter;
            return View();
        }


        public Azeroth.Klz.ActionResult Save()
        {
            var parameter = this.GetParameterUnvalidated<Model.DevDoc>();
            parameter.DateInfo = DateTime.Now;
            parameter.Author = "wch";
            BllAriticle.Save(parameter);
            return this.Redirect(string.Format("/Devolopment/Document/Item?Id={0}",parameter.Id));
        }

        public Azeroth.Klz.ActionResult Index()
        {
            List<Model.DevDoc> lst = BllAriticle.GetEntity();
            ViewData["lstDoc"] = lst;
            return View();
        }

        public Azeroth.Klz.ActionResult Item()
        {
            var parameter= this.GetParameter<Model.DevDoc>();
            Model.DevDoc article = BllAriticle.GetEntityById(parameter.Id);
            this.ViewData["doc"] = article;
            return View();
        }

        /// <summary>
        /// 处理富文本编辑器的文件上传
        /// </summary>
        /// <returns></returns>
        public Azeroth.Klz.ActionResult SaveFile()
        {
            var rst = new { err = string.Empty, msg = new { url = "!http://www.baidu.com/sa.txt", localname = "sa.txt", id = "1" } };
            return this.Json(rst);
        }
    }
}