using System;

namespace Uppgift_4._1;

class Program
{
    static void Main(string[] args)
    {
        bool avsluta = false;
        int störstHeltal = 0;


        while (avsluta != true) {
            Console.WriteLine("Vill du skriva ett heltal? Om inte, skriv 'n', annars skriv ditt heltal");
            string svar = Console.ReadLine();

            try
            {
                if (svar == "n")
                {
                    avsluta = true;
                }
                else if (störstHeltal < Convert.ToInt32(svar))
                {
                    störstHeltal = Convert.ToInt32(svar);

                }
            } catch
            {
                Console.WriteLine("Du kan endast skriva ett heltal eller 'n'");
            }
            
            
        }

        Console.WriteLine(störstHeltal);
        Console.ReadKey();
    }
}