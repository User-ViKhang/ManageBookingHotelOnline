using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using MimeKit.Text;
using MimeKit;
using Booking_Backend.Repository.SendMail.Request;
using MailKit.Security;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using Booking_Backend.Repository.SendMail.ViewModel;
using System;
using Booking_Backend.Repository.Common;

namespace Booking_Backend.Service.SendEmail
{
    public class EmailService : IEmailService
    {
        private readonly MailSettings _mailSettings;

        public EmailService(IOptions<MailSettings> mailSettingsOptions)
        {
            _mailSettings = mailSettingsOptions.Value;
        }

        public async Task<bool> SendEmail(MailData mailData)
        {
            try
            {
                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress(_mailSettings.DisplayName, _mailSettings.Mail));
                emailMessage.To.Add(new MailboxAddress(mailData.ReceiverName, mailData.ReceiverEmail));
                emailMessage.Subject = mailData.Title;
                emailMessage.Body = new TextPart("html")
                {
                    Text = mailData.Body
                };
                var username = _mailSettings.Mail;

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.Auto);
                    await client.AuthenticateAsync(_mailSettings.Mail, _mailSettings.Password);
                    await client.SendAsync(emailMessage);
                    await client.DisconnectAsync(true);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<APIResult<string>> SendEmailAsync(MailData mailData)
        {
            try
            {
                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress(_mailSettings.DisplayName, _mailSettings.Mail));
                emailMessage.To.Add(new MailboxAddress(mailData.ReceiverName, mailData.ReceiverEmail));
                emailMessage.Subject = mailData.Title;
                emailMessage.Body = new TextPart("html")
                {
                    Text = mailData.Body
                };
                var username = _mailSettings.Mail;

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.Auto);
                    await client.AuthenticateAsync(_mailSettings.Mail, _mailSettings.Password);
                    await client.SendAsync(emailMessage);
                    await client.DisconnectAsync(true);
                }
                return new APIResult_Success<string>("Gửi mail thành công!");
            }
            catch (Exception ex)
            {
                return new APIResult_Error<string>("Gửi mail thất bại!");
            }
        }
    }
}