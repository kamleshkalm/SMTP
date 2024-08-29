using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using SendemailbySMTP.model;

namespace SendemailbySMTP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendEmail( string email)
        {
            try
            {
                string smtpAddress = "smtp.gmail.com";
                int portNumber = 587;
                bool enableSSL = true;
                string emailFromAddress = "test@gmail.com"; //enter gmail Address
                string password = "hrgw xzqx bved dpnj"; //Sender app Password
                string emailToAddress = email; //Receiver Email Address
                string subject = "Hello";
                string body = "Hello, This Email is sending for test using gmail.";              

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFromAddress);
                    mail.To.Add(emailToAddress);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }

                return Ok("Email sent successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }

        }
   
        [HttpPost("outlookmsg")]
        public ActionResult Send(string recipientEmail)
        {
            // Sender's email credentials
            //string senderEmail = ""; // Your Outlook email address
            //string password = "m!"; // Your Outlook email password
            string senderEmail = "test@outlook.com"; //Your Outlook email address
            string password = "lvfwmmbjchzw"; //Your Outlook email password
            // Construct the message
            MailMessage message = new MailMessage(senderEmail, recipientEmail);
            message.Subject = "SMS from your application";

            // Hard-coded message body
            string messageBody = "Hello, this is a test SMS from our application.";

            message.Body = messageBody;

            // Configure SMTP client
            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(senderEmail, password);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                // Send the message
                smtpClient.Send(message);
                return Ok("SMS sent successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
       
    }
}
