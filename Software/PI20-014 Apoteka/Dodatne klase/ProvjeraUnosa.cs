using Org.BouncyCastle.Crypto.Signers;
using PI20_014_Apoteka.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI20_014_Apoteka.Dodatne_klase
{
    public static class ProvjeraUnosa
    {
        internal static bool ValidacijaZaposlenika(string userName, string lozinka, string email, string ime, string prezime)
        {
            bool name = false, pass = false, mail = false, Ime = false, Prezime = false;

            if (ValjanoKorisnickoIme(userName))
                name = true;
            
            if (ValjanaLozinka(lozinka))
                pass = true;

            if (ValjanEmail(email))
                mail = true;

            if (ValjanoIme(ime))
                Ime = true;

            if (ValjanoPrezime(prezime))
                Prezime = true;

            return name && pass && mail && Ime && Prezime;
        }

        

        internal static bool ValidacijaLijeka(string nazivLijeka)
        {
            bool name = false;

            if (ValjanLijek(nazivLijeka))
                name = true;

            return name;
        }

        internal static bool ValidacijaDobavljaca(int oib, string nazivDobavljaca, string adresaDobavljaca, string tel)
        {
            bool OIB = false, naziv = false, adresa = false, telefon = false;

            if (NePostojiDobavljac(oib) && IspravnaDuzina("OIB",oib.ToString(), 4, 9))
                OIB = true;

            if (ValjanaAdresa(adresaDobavljaca))
                adresa = true;

            if (IspravnaDuzina("Naziv dobavljaca", nazivDobavljaca, 4, 50))
                naziv = true;

            if (ValjanTelefonskiBroj(tel))
                telefon = true;

            return OIB && naziv && adresa && telefon;
        }

        internal static bool ValidacijaKorisnik(string korIme, string email, string lozinka, string ime, string prezime)
        {
            bool korime = false, mail = false, passw = false, Ime = false, Prezime = false;

            if (NePostojiKorisnik(korIme))
                korime = true;

            if (ValjanEmail(email))
                mail = true;

            if (ValjanaLozinka(lozinka))
                passw = true;

            if (ValjanoIme(ime))
                Ime = true;

            if (ValjanoPrezime(prezime))
                Prezime = true;

            return korime && mail && passw && Ime && Prezime;
        }


        private static bool ValjanoKorisnickoIme(string userName)
        {
            bool postoji = false, duzina = false;
            if (NePostojiKorisnik(userName))
                postoji = true;

            if (IspravnaDuzina("Korisničko ime", userName, 4, 20))
                duzina = true;

            return postoji && duzina;
        }

        public static bool ValjanaLozinka(string lozinka)
        {
            bool duzina = false, ispravanOblik = false;

            if (IspravnaDuzina("Lozinka",lozinka, 4, 30))
            {
                duzina = true;
            }
            if (IspravanOblikLozinke(lozinka))
            {
                ispravanOblik = true;
            }
            return duzina && ispravanOblik;
        }

        public static bool ValjanoIme(string ime)
        {
            bool duzina = false, ispravanOblik = false;

            if (IspravnaDuzina("Ime", ime, 3, 20))
            {
                duzina = true;
            }
            if (IspravanOblikImena(ime))
            {
                ispravanOblik = true;
            }
            return duzina && ispravanOblik;
        }

        private static bool IspravanOblikImena(string ime)
        {
            if (ime != null)
            {
                Match Oblik = Regex.Match(ime, "^[A-Za-z-]+$");
                if (Oblik.Success)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Polje ime moze sadrzavati samo velika i mala slova!");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Polje ime ne smije biti prazno");
                return false;
            }
        }

        public static bool ValjanoPrezime(string prezime)
        {
            bool duzina = false, ispravanOblik = false;

            if (IspravnaDuzina("Prezime", prezime, 3, 20))
            {
                duzina = true;
            }
            if (IspravanOblikPrezimena(prezime))
            {
                ispravanOblik = true;
            }
            return duzina && ispravanOblik;
        }

        private static bool IspravanOblikPrezimena(string prezime)
        {
            if (prezime != null)
            {
                Match Oblik = Regex.Match(prezime, "^[A-Za-z-]+$");
                if (Oblik.Success)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Polje prezime moze sadrzavati samo velika i mala slova!");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Polje prezime ne smije biti prazno");
                return false;
            }
        }

        public static bool ValjanEmail(string email)
        {
            bool duzina = false, ispravanOblik = false;

            if (IspravnaDuzina("Email",email, 4, 30))
            {
                duzina = true;
            }
            if (IspravanOblikEmaila(email))
            {
                ispravanOblik = true;
            }
            return duzina && ispravanOblik;
        }

        private static bool ValjanTelefonskiBroj(string tel)
        {
            bool duzina = false, ispravanOblik = false;

            if (IspravnaDuzina("Telefonski broj", tel, 4, 30))
            {
                duzina = true;
            }
            if (IspravanOblikTelBroja(tel))
            {
                ispravanOblik = true;
            }
            return duzina && ispravanOblik;
        }


        private static bool ValjanLijek(string nazivLijeka)
        {
            bool duzina = false, postoji = false;

            if (NePostojiLijek(nazivLijeka))
                postoji = true;
            if (IspravnaDuzina("Lijek",nazivLijeka,2,50))
                duzina = true;

            return duzina && postoji;
        }

        private static bool ValjanaAdresa(string adresaDobavljaca)
        {
            bool oblik = false, duzina = false;
            if (IspravanOblikAdrese(adresaDobavljaca))
                oblik = true;

            if (IspravnaDuzina("Adresa", adresaDobavljaca, 4, 50))
                duzina = true;

            return oblik && duzina;
        }

       

        private static bool NePostojiDobavljac(int oib)
        {
            using (var contex = new PI20_014_DBEntities())
            {
                if (contex.Dobavljac.FirstOrDefault(d => d.OIB == oib) != null)
                {
                    MessageBox.Show("Dobavljac postoji!");
                    return false;
                }
                else
                    return true;
            }
        }

        private static bool NePostojiKorisnik(string userName)
        {
            using (var contex = new PI20_014_DBEntities())
            {
                if (contex.Korisnik.FirstOrDefault(k => k.KorisnickoIme == userName) != null)
                {
                    MessageBox.Show("Korisnicko ime postoji!");
                    return false;
                }
                else
                    return true;
            }
        }
        private static bool NePostojiLijek(string nazivLijeka)
        {
            using (var context = new PI20_014_DBEntities())
            {
                if (context.Lijek.FirstOrDefault(l =>  l.Naziv == nazivLijeka) != null)
                {
                    MessageBox.Show("Lijek postoji!");
                    return false;
                }
                else
                    return true;
            }
        }

        private static bool IspravanOblikLozinke(string lozinka)
        {
            if (lozinka.Any(char.IsUpper) && lozinka.Any(char.IsLower) && lozinka.Any(char.IsDigit))
                return true;
            else
            {
                MessageBox.Show("Mora sadrzavati velika i mala slova te brojeve!");
                return false;
            }
        }

        private static bool IspravanOblikTelBroja(string tel)
        {
            Match prviOblik = Regex.Match(tel, @"^\+385\d{9}$");
            Match drugiOblik = Regex.Match(tel, @"^09\d{1}\s\d{4}\s\d{3}$");

            if (prviOblik.Success || drugiOblik.Success)
                return true;
            else
            {
                MessageBox.Show("Telefonski broj mora biti oblika +385xxxxxxxxx ili 09x xxxx xxx!");
                return false;
            }
        }
        private static bool IspravanOblikEmaila(string email)
        {
            if (email != null)
            {
                try
                {
                    MailAddress m = new MailAddress(email);
                    return true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Email mora biti oblika ime@domena!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Polje email ne smije biti prazno");
                return false;
            }
        }
        private static bool IspravanOblikAdrese(string adresaDobavljaca)
        {
            if (adresaDobavljaca.Any(char.IsUpper) || adresaDobavljaca.Any(char.IsLower) && adresaDobavljaca.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Adresa mora sadrzavati naziv ulice/trga i broj");
                return false;
            }
        }
        private static bool IspravnaDuzina(string objekt, string text, int min, int max)
        {
            if (text.Length >= min && text.Length <= max)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{objekt} mora biti minimalne duzine {min} znaka i maksimalne duzine {max} znakova!");
                return false;
            }
        }

        public static string KriptirajLozinku(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        } 

        public static string DekriptirajLozinku(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

    }
}
