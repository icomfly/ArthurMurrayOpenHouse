using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace ArthurMurrayOpenHouse.Models
{
    public class Utils
    {

        public static void SendEmail(string email, string name)
        {
            //SmtpClient smtpClient = new SmtpClient("mail.arthurmurrayopenhouse.com", 2525);

            //smtpClient.Credentials = new System.Net.NetworkCredential("noreply@arthurmurrayopenhouse.com", "Srf#020385!");
            //smtpClient.UseDefaultCredentials = true;
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.EnableSsl = false;
            //MailMessage mail = new MailMessage();
            //mail.Body = "Test";

            ////Setting From , To and CC
            //mail.From = new MailAddress("noreply@arthurmurrayopenhouse.com", "Arthur Murray Open House");
            //mail.To.Add(new MailAddress(email));
            ////mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));

            //smtpClient.Send(mail);

            SmtpClient smtpClient = new SmtpClient("arthurmurrayopenhouse.com", 25);

            smtpClient.Credentials = new System.Net.NetworkCredential("noreply@arthurmurrayopenhouse.com", "Srf#020385!");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage mailMessage = new MailMessage("noreply@arthurmurrayopenhouse.com", email);
            mailMessage.Subject = "Invitation to Lincolnshire Arthur Murray Open House";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "<h1> Hello " + name + @" ! </h1> <br/> 
                                <p>
                                You are invited to Lincolnshire Arthur Murray Open House!
                                </p>
                                <p>Event starts on <time datetime='2017-10-20 19:30'>October 20, 2017 at 7:30 PM.</time>
                                175 Olde Half Day Rd Ste 300, Lincolnshire, IL 60069
                                </p>
                                <p>
                                <img src='arthurmurrayopenhouse.com/Content/Images/Invitation.JPG'>
                                </p>
                                <hr>
                                <p>
                                Thank you! <br/>
                                Lincolnshire Arthur Murray
                                </p>";

            //Attachment attachment = new Attachment("arthurmurrayopenhouse.com/Content/Images/Invitation.JPG");
            //mailMessage.Attachments.Add(attachment);



            smtpClient.Send(mailMessage);

        }
    }
}