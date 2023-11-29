using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaZrakoplov
{
    internal class Zrakoplov
    {
        string naziv;
        string snagaMotora;
        string dosegLeta;

        public void setNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public string getNaziv()
        {
            return this.naziv;
        }
        public void setSnagaMotora(string snagaMotora)
        {
            this.snagaMotora = snagaMotora ;
        }
        public string getSnagaMotora()
        {
            return this.snagaMotora;
        }
        public void setDosegLeta(string dosegLeta)
        {
            this.dosegLeta = dosegLeta;
        }
        public string getDosegLeta()
        {
            return this.dosegLeta;
        }
        public Zrakoplov(string naziv, string snagaMotora, string dosegLeta)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.dosegLeta = dosegLeta;
        }

        public override string ToString()
        {
            string ispis = "Naziv " + this.getNaziv()
            + " Snaga motora " + this.getSnagaMotora() 
            + " Doseg leta " + this.getDosegLeta();
            return ispis;
        }
    }
}
