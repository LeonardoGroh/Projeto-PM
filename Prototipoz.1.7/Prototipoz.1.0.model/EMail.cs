using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Configuration;
using System.Net;

namespace Prototipoz._1._0.model
{

    public class EMail
    {
        
        
       public static void enviarEmail(string endereco,string nome,string senha)
       {
           try
           {

          
           //cria uma mensagem
           MailMessage mail = new MailMessage();
           //define os endereços
           mail.From = new MailAddress("mathew_souza@hotmail.com");
           mail.To.Add(endereco);
           //define o conteúdo
           mail.Subject = "Software Zoo,recuperar senha.";
           mail.Body = nome +",foi solicitada uma recuperação de senha para a sua conta,para acessa-la basta copiar o código abaixo e cola-lo no campo Senha e logo após você poderá redefinir a sua senha.\r"+ senha + "\r Caso você não tenha solicitado uma recuperação de senha informe seu superior.";
           //envia a mensagem          

           SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
           smtp.EnableSsl = true;
           NetworkCredential credencial = new NetworkCredential("EMAIL", "Senha");

           smtp.Send(mail);
              

           }
           catch (SmtpException ex)
           {

               throw new Exception(ex.Message);
           }
       }
    }
}
