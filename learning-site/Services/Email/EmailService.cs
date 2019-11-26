using learning_site.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Web;

namespace learning_site.Services.Email
{
    public class EmailService : IEmailService
    {
        public string SendEmail(EmailModel emailModel)
        {

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44393/api/SendEmail");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{" +
                    "\"Name\":\"" + emailModel.Name + "\"," +
                    "\"Email\":\"" + emailModel.Email + "\"," +
                    "\"Body\":\"" + emailModel.Body + "\"}";

                streamWriter.Write(json);
            }

            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string responce;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                responce = streamReader.ReadToEnd();
            }

            return responce;
        }


    }
}