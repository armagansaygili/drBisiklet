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
            ePosta.From = new MailAddress("info.drbisiklet@gmail.com","Dr. Bisiklet");
            ePosta.To.Add(email);
            ePosta.Subject = icerik;
            ePosta.IsBodyHtml = true;
            LinkedResource logo = new LinkedResource("C:\\Program Files (x86)\\Armsaygili\\drBisikletSetup\\drbisiklet.jpg");
            logo.ContentId = "companylogo";
            logo.ContentType.Name = "drbisiklet.jpg";
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(konu + "<p>Dr.Bisiklet <br>0533 394 03 56 <br><img src=cid:companylogo>", null, "text/html");
            
            htmlView.LinkedResources.Add(logo);
            ePosta.AlternateViews.Add(htmlView);


            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("YOUR_MAIL", "YOUR_PASS");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Send(ePosta);

        }
        
    }
}
