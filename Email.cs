using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace RecipeWebSite.Controllers
{
	public class Email
	{
		public static void sendMail(String Toemail, String body, String BCCemail)
		{
			// Command line argument must the the SMTP host.
			SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
			client.UseDefaultCredentials = true;
			client.Credentials = new System.Net.NetworkCredential("rodriguezsteven289@gmail.com", "duiqnkgpzeanvhwu");

			client.DeliveryMethod = SmtpDeliveryMethod.Network;
			client.EnableSsl = true;
			MailAddress from = new MailAddress("rodriguezsteven289@gmail.com");
			MailAddress BCC = new MailAddress(BCCemail);
			MailAddress to = new MailAddress(Toemail);
			MailMessage message = new MailMessage(from, to);
			message.Bcc.Add(BCC);
			message.Subject = "New registration.";
			message.Body = body;

			message.BodyEncoding = System.Text.Encoding.UTF8;
			client.Send(message);

			message.Dispose();
			Console.WriteLine("Goodbye.");
		}
	}
}