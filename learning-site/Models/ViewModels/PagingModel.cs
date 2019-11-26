using learning_site.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace learning_site.Models.ViewModels
{
    public class PagingModel : ContentModel
    {
        public PagingModel(ContentModel model, IOrderedEnumerable<IPublishedContent> nodes): base(model.Content) 
        {
            int displayPages =  model.Content.Value<int>("displayBlogsInOnePage");
            PagingHelper paging = new PaginagionService().GetPaging(nodes, displayPages);

            CurrentPage = paging.CurrentPage;
            TotalPages = paging.TotalPages;
            PageSize = paging.PageSize;
            Nodes = paging.Nodes;
        }


        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public IEnumerable<IPublishedContent> Nodes { get; set; }
    }
}