using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;
using Booking_Backend.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Booking_Backend.Service.SendEmail
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;
        private readonly string _from;
        private readonly string _pass;
        private readonly int _port;
        private readonly bool _enableSSL;
        private readonly string _host;


        public async Task<bool> SendEmail( string _to, string _subject, string _body)
        {
            var _from = _config["SendMailConfiguration:FromMailAddress"];
            var _pass = _config["SendMailConfiguration:Password"];
            var _port = _config["SendMailConfiguration:SMTPPort"];
            var _enableSSL = _config["SendMailConfiguration:EnableSSL"];
            var _SMTPHost = _config["SendMailConfiguration:SMTPHost"];
           MailMessage message = new MailMessage(
               from: _from,
               to: _to,
               subject: _subject,
               body: _body
           );
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            message.ReplyToList.Add(new MailAddress(_from));
            message.Sender = new MailAddress(_from);
            using var smtpClient = new SmtpClient(_SMTPHost);
            smtpClient.Port = Int32.Parse(_port);
            smtpClient.EnableSsl = Boolean.Parse(_enableSSL);
            smtpClient.Credentials = new NetworkCredential(_from, _pass);
            try
            {
                await smtpClient.SendMailAsync(message);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
