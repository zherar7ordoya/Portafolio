using MailKit.Net.Smtp;
using MimeKit;
using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IServicioEmail
    {
        Task EnviarCorreo(ContactoViewModel contacto);
    }


    public class ServicioEmail(IConfiguration config) : IServicioEmail
    {
        private readonly IConfiguration _config = config;

        public async Task EnviarCorreo(ContactoViewModel contacto)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(contacto.Nombre, contacto.Email));
            email.To.Add(new MailboxAddress("Ana de Armas", "aarmas@mail.net"));
            email.Subject = "Contacto";

            email.Body = new TextPart("plain")
            {
                Text = contacto.Mensaje
            };

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync("sandbox.smtp.mailtrap.io", 587, MailKit.Security.SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_config["USUARIO_MAILTRAP"], _config["PASSWORD_MAILTRAP"]);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}
