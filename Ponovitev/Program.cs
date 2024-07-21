using System;

namespace Ponovitev
{
    internal class Program
    {
        //Metoda za ustvarjanje polja nakljucnih stevil
        static int[] NakljucnoPolje(int velikost, int min, int max)
        {
            int[] polje = new int[velikost];
            for (int i = 0; i < polje.Length; i++)
            {
                polje[i] = new Random().Next(min, max);
            }
            return polje;
        }

        //Metoda za vsoto lihih stevil v polju
        static int VsotaLihihStevil(int[] polje)
        {
            int vsota = 0;
            for (int i = 0; i < polje.Length; i++)
            {
                if (polje[i] % 2 != 0)
                {
                    vsota += polje[i];
                }
            }
            return vsota;
        }

        //Metoda za vsoto lihih stevil v polju
        static int VsotaSodihStevil(int[] polje)
        {
            int vsota = 0;
            for (int i = 0; i < polje.Length; i++)
            {
                if (polje[i] % 2 == 0)
                {
                    vsota += polje[i];
                }
            }
            return vsota;
        }

        //Metoda za stetje samoglasnikov v nizu
        static int PrestejSamoglasnike(string besedilo)
        {
            int stevilo = 0;
            for (int i = 0; i < besedilo.Length; i++)
            {
                if (JeSamoglasnik(besedilo[i]))
                {
                    stevilo++;
                }
            }
            return stevilo;

        }

        //Metoda za preverjanje samoglasnika
        static bool JeSamoglasnik(char c)
        {
            char crka = char.ToLower(c);
            string samoglasniki = "aeiou";
            return samoglasniki.Contains(crka);
        }

        //Napišite program, ki najde najdaljši podniz v danem nizu znakov, ki ne vsebuje ponovljenih znakov.
        static string NajdaljsiNiz(string besedilo)
        {
            string niz = besedilo[0].ToString();
            string najdaljsiNiz = "";
            for (int i = 0; i < besedilo.Length; i++)
            {
                for (int j = 0; j < niz.Length; j++)
                {
                    if (niz[j] == besedilo[i])
                    {
                        if (niz.Length > najdaljsiNiz.Length) najdaljsiNiz = niz;
                        niz = besedilo[i].ToString();
                        break;
                    }
                    else
                    {
                        niz = niz + besedilo[i];
                        break;
                    }
                }
            }
            return najdaljsiNiz;  
        }

        //Številčne permutacije
        //Program naj prebere niz števil in generira vse permutacije števil.
        static int[] BranjeStevil(string stevila)
        {
            string[] stevilke = stevila.Split(' ');
            int[] rezultat = new int[stevilke.Length];
            for (int i = 0; i < stevilke.Length; i++)
            {
                rezultat[i] = int.Parse(stevilke[i]);
            }
            return rezultat;
        }
        static List<string> Permutacija(string beseda)
        {
            List<string> rezultat = new List<string>();
            //TODO
            return rezultat;
        }

        // **METODE ZA IZPIS**
        static void IzpisPolja(int[] polje)
        {
            Console.WriteLine("Polje:");
            foreach (var st in polje)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("____________");
        }
        static void Main(string[] args)
        {
            int[] polje = NakljucnoPolje(10, 0, 500);
            IzpisPolja(polje);
            Console.WriteLine("Vsota lihih števil:" + VsotaLihihStevil(polje));
            Console.WriteLine("Vsota sodih števil:" + VsotaSodihStevil(polje));
            Console.WriteLine("*************************************************");
            Console.WriteLine("Vpiši stavek:");
            string besedilo = Console.ReadLine();
            Console.WriteLine("Število samoglasnikov:" + PrestejSamoglasnike(besedilo));
            Console.WriteLine("*************************************************");
            Console.WriteLine("Najdaljsi niz:" + NajdaljsiNiz("abcceabcdeabcabcabcdefgabcde"));
            Console.WriteLine("*************************************************");
            Console.WriteLine("Vpiši cela števila ločena s presledkom:");
            int[] poljeStevil = BranjeStevil(Console.ReadLine());
            IzpisPolja(poljeStevil);
            
        }
    }
}
