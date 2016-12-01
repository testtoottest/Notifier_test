using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Collections;

namespace Notifier_test
{
    class Email
    {
        public static void sendMessage()
        {

            MailMessage message = new MailMessage();
            message.To.Add(new MailAddress("testtoottest@gmail.com"));
            message.To.Add(new MailAddress("testtoottest@gmail.com"));
            message.From = new System.Net.Mail.MailAddress("testtoottest@gmail.com");
            message.Subject = "test";
            message.Body = "super email notifier";

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("testtoottest@gmail.com", "test1234.");
            client.Host = "smtp.gmail.com";

            message.IsBodyHtml = true;
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateMessageWithAttachment(): {0}",
                            ex.ToString());
            }

        }
    }
}
