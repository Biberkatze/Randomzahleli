using System;
namespace Random_zahleli
{
    class Program
    {
        static void Main()   
        {
            int versuch = 0;
            int Zahl = new Random().Next(1, 100);
            Console.WriteLine("A number was generated");
            int Eingabe = 0;
            while (Eingabe != Zahl)
            {
                try
                {
                    Console.WriteLine("Enter a number between 1 and 100.");
                    Eingabe = Convert.ToInt32(Console.ReadLine());
                    versuch = versuch + 1;

                    if (Zahl == Eingabe)
                    {
                        Console.WriteLine("You got it");
                        Console.WriteLine("It took " + versuch + " tries to get it.");
                    }
                    else
                    {
                        if (Zahl > Eingabe)
                        {
                            Console.WriteLine("Too small, think bigger");
                        }
                        else
                        {
                            Console.WriteLine("Too big, think smaller");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
            Console.ReadLine();
        }
    }
}