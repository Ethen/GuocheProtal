using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace GuocheProtal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Index = 1;
            return View();
        }

        public ActionResult News()
        {
            ViewBag.Index = 3;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Product()
        {
            ViewBag.Index = 2;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Join()
        {
            ViewBag.Index = 4;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Index = 5;
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string SendMail(string name,string useremail, string mailContent)
        {
            string result = "";
            // 设置发送方的邮件信息,例如使用网易的smtp
            string smtpServer = ConfigurationManager.AppSettings["mailServer"].ToString(); //SMTP服务器
            string mailFrom = ConfigurationManager.AppSettings["mailFrom"].ToString(); //登陆用户名
            string userPassword = ConfigurationManager.AppSettings["mailPwd"].ToString();//登陆密码
            string mailTo = ConfigurationManager.AppSettings["mailTo"].ToString();//登陆密码

            // 邮件服务设置
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
            smtpClient.Host = smtpServer; //指定SMTP服务器
            smtpClient.Credentials = new System.Net.NetworkCredential(mailFrom, userPassword);//用户名和密码

            // 发送邮件设置       
            string content = string.Format("姓名:{0}<br/>邮箱地址:{1}<br/>留言信息:{2}", name, useremail, mailContent);


            MailMessage mailMessage = new MailMessage(mailFrom, mailTo); // 发送人和收件人
            mailMessage.Subject = "客户官网留言";//主题
            mailMessage.Body = content;//内容
            mailMessage.BodyEncoding = Encoding.UTF8;//正文编码
            mailMessage.IsBodyHtml = true;//设置为HTML格式
            mailMessage.Priority = MailPriority.Normal;//优先级

            try
            {
                smtpClient.Send(mailMessage); // 发送邮件
                result = "T";
   
            }
            catch (SmtpException ex)
            {
                result = "F";
            }

            return result;
        }
    }
}