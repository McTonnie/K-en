
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class Program
    {
            //initializeing the queue filmkø
            static Filmkø filmkø = new Filmkø();
        static void Main(string[] args)
        {

            bool power = true;

            do
            {
                menu();
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        {
                            try
                            {

                            filmkø.Kø.Peek();
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Der er inegn film i køen");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            if (filmkø.Kø.Count == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Der er inegn film i køen");
                            }
                            else
                            {
                                showmovies();
                            }
                            Console.ReadKey();
                            break;
                        }

                    case ConsoleKey.D3:
                        {
                            searchmovie();
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            addmovie();
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            filmkø.Kø.Dequeue();
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.D9:
                        {
                           
                            power = false;
                            break;
                        }

                }
            } while (power);


            
            
            
            


            
        }


        public static void menu()
        {
            //thsi is the menu ui
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("        watchlist       ");
            Console.WriteLine("========================");
            Console.WriteLine();
            Console.WriteLine("1) Vis næste film i rækken ");
            Console.WriteLine("2) Vis Filmkø");


            Console.WriteLine("3) Søg efter film");
            Console.WriteLine("4) Tilføj Film");
            Console.WriteLine("5) Fjern næste Film i køen");

            Console.WriteLine("9) Exit");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Instast valg");


        }




        public static void addmovie()
        {
            //getting users input of what the movies proberties are
            Console.Clear();
            Console.WriteLine("Tast Navn på film");
            string name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Tast den tjeneste hvor man kan se filmen");
            string tjeneste = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Tast genre på flimen");
            string genre = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Tast årstal på flimen");
            int year = integertjek();
            //creating a new movie with the users input
            Film film = new Film(name, tjeneste, genre, year);
            //adding the movie just added to the queue
            filmkø.tilføjkø(film);
            



            
        }



        //showing the queue
        public static void showmovies()
        {
            Console.Clear();  
            foreach (Film film in filmkø.Kø)
            {
                Console.WriteLine("Navn:" + film.Navn + "    Genre:" + film.Genre + "    Tjeneste:" + film.Tjeneste + "    Årstal:" + film.Årstal);
            }
            

        }


        public static void searchmovie()
        {
            Console.Clear();
            //getting the users search string
            Console.WriteLine("instast dit søge kriterie");
            string search = Console.ReadLine();
            Console.Clear();

            //this is for getting the number in the queue
            int number = 0;
            //this is fro being able to wirte that there was no resualt
            bool foundatleast1 = false;
            foreach (Film film in filmkø.Kø)
            {
                number++;
                if (film.Navn.Contains(search) || film.Genre.Contains(search) || film.Tjeneste.Contains(search) || film.Årstal.ToString().Contains(search))
                {
                    Console.WriteLine("Navn:" + film.Navn + "    Genre:" + film.Genre + "    Tjeneste:" + film.Tjeneste + "    Årstal:" + film.Årstal + " Nummer " + number + " i køen");
                    foundatleast1 = true;
                }

            }
            if (!foundatleast1)
            {
                Console.WriteLine("Der var inegn resultater");
            }

        }





        //this is a method to check if the user has given an integer and if not it will loop until its and integer
        public static int integertjek()
        {

            int res = 0;
            string temp = Console.ReadLine();
            while (!int.TryParse(temp, out res))
            {
                Console.Write("Indtast et heltal: ");
                temp = Console.ReadLine();

            }
            return res;

        }
    }
}
