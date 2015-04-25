using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Mail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string asunto = "Informes", nombre = String.Empty, mensaje = String.Empty, email = String.Empty;
        try
        {
            nombre = Request.Form["nombre"].ToString();
            mensaje = Request.Form["mensaje"].ToString();
            email = Request.Form["correo"].ToString();
            string correo = "qweqwe12399@outlook.com";
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(correo);
            mail.Subject = string.Format("{0} para: {1}", asunto, nombre);
            mail.Body = string.Format("Mensaje {0} de {1}. Contacto {2} ", mensaje, nombre, email);
            mail.Priority = MailPriority.Normal;
            string para = "cesar.gutman@outlook.com";
            mail.To.Add(para);
            SmtpClient client = new SmtpClient();
            client.Host = "smtp-mail.outlook.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //poner las credenciales 
            client.Credentials = new NetworkCredential("qweqwe12399@outlook.com", "Aa_12345");
            client.Timeout = 30000;
            client.Send(mail);
        }
        catch (Exception ex)
        {
            
        }
        Response.Redirect("index.html");
    }
}