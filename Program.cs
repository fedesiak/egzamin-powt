using System;

namespace szyfr
{

    public class Szyfrowanie 
    {
        public string zaszyfruj(string tekst, int klucz)
        {
            string tekstZaszyfrowany = "";
            string alfabet = "abcdefghijklmnopqrstuvwxyz";

            for(int i =0; i<tekst.Length; i++)
            {
                if (tekst[i] == ' ')
                {
                    tekstZaszyfrowany += ' ';
                }
                else
                {
                    for (int j = 0; j < alfabet.Length; j++)
                    {
                        if (tekst[i] == alfabet[j])
                        {
                            int index = j + klucz;
                            if (index >= alfabet.Length)
                            {
                                index = index - alfabet.Length;
                            }
                            else if (index < 0)
                            {
                                index = index + alfabet.Length;
                            }
                            tekstZaszyfrowany += alfabet[index];
                        }
                    }
                }
               

            }


            return tekstZaszyfrowany;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szyfrowanie szyfrowanie = new Szyfrowanie();
            Console.WriteLine("Podaj tekst: ");
            string tekst = Console.ReadLine();
            Console.WriteLine("Podaj klucz: ");
            int klucz = int.Parse(Console.ReadLine());
            Console.WriteLine("Zaszyfrowany tekst: "+szyfrowanie.zaszyfruj(tekst, klucz));


        }
    }

}

