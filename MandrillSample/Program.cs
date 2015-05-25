using System.Collections.Generic;
using Mandrill;
using Mandrill.Models;
using Mandrill.Requests.Messages;

namespace MandrillSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string apiKey = "your_api_key_here";
            const string toEmail = "your_email_here";
            const string fromEmail = "test@test.com";
            const string templateExample = "email-verification";
            var mandrill = new MandrillApi(apiKey);
            List<EmailResult> result = mandrill.SendMessageTemplate(new SendMessageTemplateRequest
                                                                              (new EmailMessage
                                                                                  {
                                                                                      To =
                                                                                          new List<EmailAddress>
                                                                                              {
                                                                                                  new EmailAddress
                                                                                                      {
                                                                                                          Email =
                                                                                                              toEmail,
                                                                                                          Name = ""
                                                                                                      }
                                                                                              },
                                                                                      FromEmail = fromEmail,
                                                                                      Subject =
                                                                                          "Mandrill Integration Test",
                                                                                  },
                                                                               templateExample,
                                                                               new List<TemplateContent>
                                                                                   {
                                                                                       new TemplateContent
                                                                                           {
                                                                                               Name = "TITLE",
                                                                                               Content = "Content1"
                                                                                           },
                                                                                       new TemplateContent
                                                                                           {
                                                                                               Name = "CONTENT",
                                                                                               Content = "Content2"
                                                                                           }
                                                                                   })).Result;
        }
    }
}