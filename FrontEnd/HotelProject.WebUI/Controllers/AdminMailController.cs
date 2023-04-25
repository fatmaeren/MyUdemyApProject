using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage= new MimeMessage();

            //Göndereci Maili
            MailboxAddress mailbox =new MailboxAddress("HotellierApi", "fatma.eren@hcbilisim.com.tr");
            mimeMessage.From.Add(mailbox);

            //Alıcı Maili
            MailboxAddress mailBoxReceiver = new MailboxAddress("User", model.RecevierMail);
            mimeMessage.To.Add(mailBoxReceiver);

            //Mesajın İçerik kısmı
            var bodyBuilder= new BodyBuilder();
            bodyBuilder.TextBody= model.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();

            //Mesaj Başlığı
            mimeMessage.Subject=model.Subject;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587);
            smtpClient.Authenticate("fatma.eren@hcbilisim.com.tr", "wicrquhvsnmtkvax");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            return View();
        }
    }
}
