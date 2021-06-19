using CS162S21GID14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CS162S21GID14.Controllers
{
    public class LoginViewController : Controller
    {
        // GET: Login
        public ActionResult LoginView()
        {
            return View();
        }
        public ActionResult RegisterationVerificationView()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SendMailToUser()
        {
            bool result = false;
            Random num = new Random();
            int randNum = num.Next(1000000, 9999999);
            result = SendEmail("azeemhashmi1826@gmail.com", "Verification Code", "<p>Hi Syed Azeem Ali Hashmi,<br/>" + "Your confirmation code is: " + randNum + "<br/>Regards AE-Connect</p>");

            return Json(result, JsonRequestBehavior.AllowGet);

        }


        public bool SendEmail(string toEmail, string subject, string emailBody)
        {

            try
            {
                string senderEmail = System.Configuration.ConfigurationManager.AppSettings["SenderEmail"].ToString();
                string senderPassword = System.Configuration.ConfigurationManager.AppSettings["SenderPassword"].ToString();

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("ehsaan2611@gmail.com", senderPassword);

                MailMessage mailMessage = new MailMessage("ehsaan2611@gmail.com", toEmail, subject, emailBody);
                mailMessage.IsBodyHtml = true;
                mailMessage.BodyEncoding = UTF8Encoding.UTF8;
                client.Send(mailMessage);
                return true;

            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;

            }
        }


    }
}