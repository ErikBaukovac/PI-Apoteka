using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PI20_014_Apoteka.Entity_Framework
{
    public partial class Korisnik
    {
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
