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


        public void send(string text)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(mail, pwd),
                EnableSsl = true
            };
            client.Send(mail, mail, "test", "testbody");
        }
    }
}
