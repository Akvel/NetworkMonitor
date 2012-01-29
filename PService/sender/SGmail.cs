using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace PService.sender
{
    public class SGmail
    {
        private string mail = @"";
        private string pwd = @"";
        private string smtp = "smtp.gmail.com";
        private int port = 587;


        public SGmail(string mail, string pwd, string smtp, int port)
        {
            this.smtp = smtp;
            this.port = port;
            this.mail = mail;
            this.pwd = pwd;
        }

        public void send(string mailTo, string text)
        {
            var client = new SmtpClient(smtp, port )
            {
                Credentials = new NetworkCredential(mail, pwd),
                EnableSsl = true
            };
            client.Send(mail, mailTo, "Monitoring Event", text);
        }
    }
}
