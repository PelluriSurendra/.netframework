using MySportCartFramework.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace MySportCartFramework.Utilities
{
    static class Mailer
    {
        const string SmtpServer = MailConstants.SmtpServer;
        const int SmtpPort = MailConstants.SmtpPort;
        const string FromEmailId = MailConstants.FromEmail;
        const string Password = MailConstants.Password;
        public static void SendMail(string mailIds, string subject, string body, string reportFileName)
        {
            SmtpClient client = new SmtpClient(SmtpServer, SmtpPort) {
                Credentials = new NetworkCredential(FromEmailId, Password),
                EnableSsl = true
            };

            MailMessage message = new MailMessage();

            Attachment attachment = new Attachment(reportFileName, MediaTypeNames.Application.Octet);
            message.Attachments.Add(attachment);

            foreach (var item in mailIds.Split(new[] { ";"}, StringSplitOptions.RemoveEmptyEntries))
            {
                message.To.Add(item);
            }

            message.From = new MailAddress(FromEmailId);
            message.Body = body;
            message.Subject = subject;
            message.IsBodyHtml = true;

            try
            {
                client.Send(message);
            }
            catch(Exception e)
            {
                
            }
        }
    }
}
