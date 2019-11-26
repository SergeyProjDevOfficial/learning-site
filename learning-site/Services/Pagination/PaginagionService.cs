using learning_site.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace learning_site.Services
{
    public class PaginagionService
    {
        public PagingHelper GetPaging(IOrderedEnumerable<IPublishedContent> nodes, int renderPages)
        {
            PagingHelper paging = new PagingHelper();

            paging.PageSize = renderPages;

            int currentPage; // The page we are viewing

            if (!int.TryParse(HttpContext.Current.Request.QueryString["page"], out currentPage))
            {
                currentPage = 1;
            }

            int totalNodes = nodes.Count();
            paging.TotalPages = (int)Math.Ceiling((double)totalNodes / (double)paging.PageSize);

            /* Bounds checking */

            if (currentPage > paging.TotalPages)
            {
                currentPage = paging.TotalPages;
            }
            else if (currentPage < 1)
            {
                currentPage = 1;
            }

            paging.Nodes = nodes.Skip((currentPage - 1) * paging.PageSize).Take(paging.PageSize);
            paging.CurrentPage = currentPage;

            return paging;
        }

    }
}