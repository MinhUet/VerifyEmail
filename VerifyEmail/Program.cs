using EASendMail;
using System;

namespace Google.Ads.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SmtpMail oMail = new SmtpMail("TryIt");

                // Set sender email address, please change it to yours
                oMail.From = "dvhung.rac1@gmail.com";

                // Set recipient email address, please change it to yours
                oMail.To.Add(new MailAddress("dvhung.rac2@gmail.com"));
                //oMail.To.Add(new MailAddress("lallalalalalal1111@gmail.com"));
                //oMail.To.Add(new MailAddress("lallalalalalal222222@gmail.com"));

                // Do not set SMTP server address
                SmtpServer oServer = new SmtpServer("");

                Console.WriteLine("start to test email address ...");

                SmtpClient oSmtp = new SmtpClient();
                oSmtp.TestRecipients(oServer, oMail);

                Console.WriteLine("email address was verified!");
            }
            catch (SmtpServerException ep)
            {
                Console.WriteLine("failed to test email with the following error:");
                Console.WriteLine(ep.Message);
            }

        }
    }
}
