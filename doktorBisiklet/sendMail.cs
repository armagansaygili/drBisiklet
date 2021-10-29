using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace doktorBisiklet
{
    class sendMail
    {
        public void mailGonder(string email, string icerik, string konu)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("armaganozan@gmail.com","Dr. Bisiklet");
            ePosta.To.Add(email);
            ePosta.Subject = icerik ;
            ePosta.IsBodyHtml = true;
            ePosta.Body = konu;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("armaganozan@gmail.com", "32731219222Ar");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Send(ePosta);

        }
        
    }
}
