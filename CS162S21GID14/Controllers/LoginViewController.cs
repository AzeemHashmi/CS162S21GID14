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
        public JsonResult SendMailToUser(Account Account)
        {
            bool result = false;
            Random num = new Random();
            int randNum = num.Next(1000000, 9999999);
            result = SendEmail(Account.Email, "Verification Code", "<p>Hi, "+Account.Name+"<br/>" + "Your confirmation code is: <b>" + randNum + "</b><br/>Regards AE-Connect</p>");
            return Json(randNum, JsonRequestBehavior.AllowGet);
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
                client.Credentials = new NetworkCredential("ae123connect@gmail.com", senderPassword);

                MailMessage mailMessage = new MailMessage("ae123connect@gmail.com", toEmail, subject, emailBody);
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