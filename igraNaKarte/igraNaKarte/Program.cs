﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraNaKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karte = 0;
            int cardCounter = 0;


            Console.WriteLine("Unesite vrijednost karte od 1-13");

            while (cardCounter < 31) { 
                karte = Convert.ToInt32(Console.ReadLine());

                if (karte <=13 && karte >= 1)
                {
                    cardCounter += karte;
                }
                else { Console.WriteLine("Unesi ispravnu kartu od 1 do 13"); }

            }

            if (cardCounter == 31)
                {
                    Console.WriteLine("Pobjeda");
                    
                }
                else if (cardCounter > 31) {
                    Console.WriteLine("Gubitak");
                }
                Console.ReadKey();
            



        }
    }
}
