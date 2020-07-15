using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace MailLib
{
    public class MailKlijent
    {
		public void PosaljiMail(string posiljatelj, string mailPosiljatelja, string primatelj, string mailPrimatelja, string apoteka,string adresa)
		{
			var message = new MimeMessage();

			message.From.Add(new MailboxAddress(posiljatelj, mailPosiljatelja));
			message.To.Add(new MailboxAddress(primatelj, mailPrimatelja));
			message.Subject = "Rezervacija aktivna";

			message.Body = new TextPart("plain")
			{
				Text = $@"Poštovani,
u apoteku {apoteka} na adresi {adresa} stigla je zaliha lijekova koje ste naručili. Možete ih doći pokupiti."
			};

			using (var client = new SmtpClient())
			{
				client.Connect("gmail-smtp-in.l.google.com", 25, false);

				client.Send(message);
				client.Disconnect(true);
			}
		}

        public void AutomatskiMail(string posiljatelj, string primatelj, string mailPrimatelja,List<string> lijekovi,int dani)
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress(posiljatelj, "ebaukovac@foi.hr"));
            message.To.Add(new MailboxAddress(primatelj, mailPrimatelja));
            message.Subject = "Rezervacija aktivna";

            string listaLijekova="";

            foreach (var lijek in lijekovi)
            {
                listaLijekova += $"{lijek}, ";
            }

            message.Body = new TextPart("plain")
            {
                Text = $@"Poštovani,
unutar {dani} dana ovi lijekovi će nestati {listaLijekova}"
            };

            
           
            using (var client = new SmtpClient())
            {
                client.Connect("gmail-smtp-in.l.google.com", 25, false);

                client.Send(message);
                client.Disconnect(true);
            }
        }

	}
}
