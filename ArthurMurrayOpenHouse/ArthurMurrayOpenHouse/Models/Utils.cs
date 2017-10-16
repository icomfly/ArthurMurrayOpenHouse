using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace ArthurMurrayOpenHouse.Models
{
    public class Utils
    {
        public static void SendEmail(string email, string name, string phone)
        {
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
            smtpClient.Send(mailMessage);

            //Now send email to our manager's email
            mailMessage = new MailMessage("noreply@arthurmurrayopenhouse.com", "amlincolnshire@yahoo.com");

            //mailMessage = new MailMessage("noreply@arthurmurrayopenhouse.com", "team@icomfly.com");


            mailMessage.Subject = "Report about new invitation to Lincolnshire Arthur Murray Open House";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = @"<h1> Hi Arthur Murray Lincolnshire! </h1> <br/> 
                                <p>
                                New invitation to Lincolnshire Arthur Murray Open House October 20, 2017 event just was sent to:</p>  
                                </p>
                                <b>Name:</b> " + name +
                                "</p><p>" +
                                "<b>Phone:</b> " + phone +
                                "</p><p>" +
                                "<b>E-mail:</b> " + email +
                                @"</p>
                                <hr>
                                <p>
                                Thank you! <br/>
                                Your Arthur Murray Open House web site
                                </p>";
            smtpClient.Send(mailMessage);


        }
    }
}