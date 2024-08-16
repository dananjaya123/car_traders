using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Common
{
    internal class EmailSend
    {
        private readonly string smtpServer;
        private readonly int smtpPort;
        private readonly string smtpUser;
        private readonly string smtpPass;

        public EmailSend()
        {
            // Initialize with your SMTP settings
            //smtpServer = "sandbox.smtp.mailtrap.io";
            //smtpPort = 2525;
            //smtpUser = "b78e467bca1f56";
            //smtpPass = "83523c1497d20b";

            // Initialize with Gmail SMTP settings
            smtpServer = "smtp.gmail.com";
            smtpPort = 587; // Gmail SMTP port for TLS
            smtpUser = "asidananjaya123@gmail.com"; 
            smtpPass = "ugpy frpp emgs jenq";
        }

        public Boolean SendEmail(string fromEmail, string toEmail, string subject, string body)
        {
            try
            {
                var client = new SmtpClient(smtpServer, smtpPort)
                {
                    Credentials = new NetworkCredential(smtpUser, smtpPass),
                    EnableSsl = true
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(fromEmail),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true // Set to true if you're sending HTML content
                };

                mailMessage.To.Add(toEmail);

                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
               return false;
            }
        }
    }

}
