using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    public class Film
    {

        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        private string tjeneste;

        public string Tjeneste
        {
            get { return tjeneste; }
            set { tjeneste = value; }
        }


        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }



        private int årstal;

        public int Årstal
        {
            get { return årstal; }
            set { årstal = value; }
        }


        public Film(string name, string service, string genre, int year) 
        {

            this.navn = name;
            this.tjeneste = service;
            this.genre = genre;
            this.årstal = year;
            

        }




    }
}
