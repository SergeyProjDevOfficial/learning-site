using learning_site.Models;
using learning_site.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;

namespace learning_site.Controllers
{
    public class ArticlesMainController : RenderMvcController
    {
        // by aliasName
        public ActionResult ArticlesMain(ContentModel model)
        {
            var nodes = Umbraco.Content(model.Content.Key)
                .ChildrenOfType("articlesItem")
                .Where(x => x.IsVisible())
                .OrderBy(x => x.CreateDate);

            var viewModel = new PagingModel(model, nodes);

            return View(viewModel);
        }
    }
}