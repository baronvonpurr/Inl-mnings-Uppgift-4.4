using System;

namespace Uppgift4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett av följande alternativ");
            string meny = "";
            double beräkning;
            double beräkning2;

            while (meny != "3")
            {
                Console.WriteLine("1 Subtrahera ett tal med ett annat.");
                Console.WriteLine("2 Dividera ett tall med ett annat.");
                Console.WriteLine("3 Avsluta programmet");
                meny = Console.ReadLine();

                switch (meny)
                {
                    case "1":
                        Console.WriteLine("Skriv in ditt första tal");
                        beräkning = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in ditt andra tal");
                        beräkning2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Det blir " + (beräkning - beräkning2));
                        break;
                    case "2":
                        Console.WriteLine("Skriv in nämnaren");
                        beräkning = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in täljaren");
                        beräkning2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Det blir " + (beräkning / beräkning2));
                        break;
                    case "3":
                        Console.WriteLine("Programmet avslutas");
                        break;
                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ");
                        break;
                }
            }
        }
    }
}