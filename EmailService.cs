using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Humanizer.Configuration;
namespace GFAS.Email
{
    public class EmailService
    {
        private readonly IConfiguration configuration;

        public EmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task SendEmailAsync(string toEmail, string ccEmail, string bccEmail, string subject, string message)
        {
            var emailSettings = configuration.GetSection("EmailSettings");
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(emailSettings["SenderName"], emailSettings["SenderEmail"]));
            email.To.Add(new MailboxAddress(toEmail, toEmail));

            if (!string.IsNullOrEmpty(ccEmail))
            {
                email.Cc.Add(new MailboxAddress(ccEmail, ccEmail));
            }
            if (!string.IsNullOrEmpty(bccEmail))
            {
                email.Bcc.Add(new MailboxAddress(bccEmail, bccEmail));
            }
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html)
            {
                Text = message
            };

            using (var smtp = new SmtpClient())
            {
                smtp.Connect(emailSettings["SMTPServer"], int.Parse(emailSettings["SMTPPort"]), MailKit.Security.SecureSocketOptions.None);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
        }
    }
}
