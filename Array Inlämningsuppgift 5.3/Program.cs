using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] frågor = { "Vad heter Sveriges huvudstad? ", "Vilken är Sveriges största stad? ", "Vilken stad i Sverige börjar på V och slutar på äxjö? ", "Vad heter Norges huvudstad? " };
            string[] FrågorSvar = { "Stockholm", "Stockholm", "Växjö", "Oslo" };

            Console.Write("Välj en fråga mellan 1-4 : ");
            int VilkenFråga=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fråga "+VilkenFråga+" : " + frågor[VilkenFråga-1]); 
            string Svar=Console.ReadLine();

            if (Svar == FrågorSvar[VilkenFråga-1])
            {
                Console.WriteLine("Rätt!"); 
            }

            else
                Console.WriteLine("Fel!");


        }
    }
}
