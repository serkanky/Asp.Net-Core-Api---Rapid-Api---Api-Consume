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
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("KayaResort", "mserkankaya2363@gmail.com");      //KİMDEN
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);               //KİME
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();                                    //İÇERİK
            bodyBuilder.TextBody=model.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();

            mimeMessage.Subject=model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("mserkankaya2363@gmail.com", "gcevpfzunidpxvkk");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
