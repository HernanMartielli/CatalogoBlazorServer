using CatalogoBlazorServer.Models;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CatalogoBlazorServer.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly MailSmtpSettings _mailSmtpSettings;

        public EmailSenderService(IOptions<MailSmtpSettings> mailSmtpSettings)
        {
            _mailSmtpSettings = mailSmtpSettings.Value;
        }   

        public async Task SendEmailAsync(MailRequest request)
        {
            try
            {
                var mensaje = new MimeMessage();
                mensaje.From.Add(new MailboxAddress(_mailSmtpSettings.SenderName, _mailSmtpSettings.SenderEMail));
                mensaje.To.Add(new MailboxAddress("", request.Email));
                mensaje.Subject = request.Subject;
                mensaje.Body = new TextPart ("html") { Text = request.Body };

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_mailSmtpSettings.Server);
                    await client.AuthenticateAsync(_mailSmtpSettings.UserName, _mailSmtpSettings.Password);
                    await client.SendAsync(mensaje);
                    await client.DisconnectAsync(true);

                }

            }
            catch (Exception)
            {

            }

        }
    }
}
