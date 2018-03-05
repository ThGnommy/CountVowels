using System;
using System.Text;

// Enter a string and the program counts the number of vowels in the text. For added complexity have it report a sum of each vowel found.

namespace Vocali
{
    class Program
    {
        static void Main(string[] args)
        {
            int countA = 0;
            int countE = 0;
            int countI = 0;
            int countO = 0;
            int countU = 0;

            Console.Write("Inserisci una stringa: ");

            string s = Console.ReadLine();

            foreach (char item in s)
            {
                if(item.ToString() == "a")
                {
                    countA++;
                }

                if (item.ToString() == "e")
                {
                    countE++;
                }

                if (item.ToString() == "i")
                {
                    countI++;
                }

                if (item.ToString() == "o")
                {
                    countO++;
                }

                if (item.ToString() == "u")
                {
                    countU++;
                }
            }

            Console.WriteLine("Ci sono: " + countA + " 'A' " + "in questa frase.");
            Console.WriteLine("Ci sono: " + countE + " 'E' " + "in questa frase.");
            Console.WriteLine("Ci sono: " + countI + " 'I' " + "in questa frase.");
            Console.WriteLine("Ci sono: " + countO + " 'O' " + "in questa frase.");
            Console.WriteLine("Ci sono: " + countU + " 'U' " + "in questa frase.");

            }
        }
    }
