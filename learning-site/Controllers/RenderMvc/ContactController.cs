using learning_site.Models.ViewModels;
using learning_site.Services.Email;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace learning_site.Controllers
{
    public class ContactController : RenderMvcController
    {
        private readonly IEmailService service;

        public ContactController()
        {
            this.service = new EmailService();
        }


        // It called FormCollection and it was an signature of method.
        // To call it`s  fields you can use formCollection["name"]
        [HttpPost]
        public ActionResult Contact(string email, string name, string message)
        {
            EmailModel emailModel = new EmailModel()
            {
                Email = email,
                Name = name,
                Body = message
            };

            string sendingResult = service.SendEmail(emailModel);

            return Content(sendingResult);
        }
    }
}