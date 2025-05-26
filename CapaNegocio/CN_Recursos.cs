using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace CapaNegocio
{
    public class CN_Recursos
    {
        //Método para recuperar / generar clave automática para enviar al usuario por correo
        public static string GenerarClave()
        {
            string clave = Guid.NewGuid().ToString("N").Substring(0, 6);
            return clave;
        }

        //Encriptación de texto a SHA256
        public static string ConvertirSha256(string texto)
        {
            StringBuilder sb = new StringBuilder();

            //Usar la referencia de "System.Security.Criptography"
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result)
                    sb.Append(b.ToString("2"));
            }
            return sb.ToString();
        }

        //Método para enviar correo electrónico
        public static bool EnviarCorreo(string correo, string asunto, string mensaje)
        {
            bool resultado = false;

            try
            {
                //Crear el mensaje de correo
                //Configuración del correo
                MailMessage mail = new MailMessage();
                mail.To.Add(correo);
                mail.From = new MailAddress("pruebasdev979@gmail.com");
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = true;

                //Creación del servidor que enviará el correo
                var smtp = new SmtpClient()
                {
                    Credentials = new NetworkCredential("pruebasdev979@gmail.com", "qfmi cmji qjzs nnuu"),
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true
                };

                //Envío del correo
                smtp.Send(mail);
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
            }

            return resultado;

        }


        //Método para guardar imagen en el servidor
        public static string ConvertirBase64 (string ruta, out bool conversion) {
            string textoBase64 = string.Empty;
            conversion = true;

            try {
                byte[] bytes = File.ReadAllBytes(ruta);
                textoBase64 = Convert.ToBase64String(bytes);
            }
            catch
            {
                conversion = false;
            }
            return textoBase64;
        }
    }
}
