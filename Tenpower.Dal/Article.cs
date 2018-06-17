using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenpower.Dal
{
    [System.ComponentModel.Composition.Export(typeof(IDal.IDevDoc))]
    public class Article:Resposity<Model.DevDoc>,IDal.IDevDoc
    {
        void IDal.IDevDoc.Save(Model.DevDoc article)
        {
            if (Guid.Empty == article.Id)
            {
                article.Id = Guid.NewGuid();
                this.Add(article);
            }
            else
            {
                this.Cast<IDal.IDevDoc>().Edit(article);
            }
        }

        void IDal.IDevDoc.Edit(Model.DevDoc article)
        {
            var tableArticle = this.DbContext.DbSet<Model.DevDoc>();
            tableArticle.Select(x => new { x.Value, x.Title });
            tableArticle.Where(x => x.Id, Azeroth.OMT.WH.EQ, article.Id);
            tableArticle.Edit(article);
            tableArticle.SaveChange();
        }

    }
}
