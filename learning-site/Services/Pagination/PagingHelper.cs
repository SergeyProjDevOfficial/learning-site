using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace learning_site.Services
{
    public class PagingHelper
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public IEnumerable<IPublishedContent> Nodes { get; set; }
    }
}