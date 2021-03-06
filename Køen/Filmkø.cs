using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    public class Filmkø
    {
        private static Queue<Film> kø = new Queue<Film>();


        public Filmkø() { }



        public Queue<Film> Kø
        {
            
            get { return kø; }
        }

        public void fjernkø()
        {
            kø.Dequeue();
        }
        
        public void tilføjkø(Film film)
        {
            kø.Enqueue(film);
        }
    }
}
