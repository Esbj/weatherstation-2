using System;
using System.Collections.Generic;
namespace Väderstationen
{
    class Program
    {
        static List<int> weatherData = new List<int>();
        static void printMenu()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("                Vad vill du göra?");
            Console.WriteLine("");
            Console.WriteLine("[L]ägg till tempratur");
            Console.WriteLine("[S]kriv ut alla tempraturer & medeltemraturen");
            Console.WriteLine("[T]a bort ett värde");
            Console.WriteLine("[A]vsluta");
            Console.WriteLine("--------------------------------------------------");
        }
        static int printAll_CountMedian(List<int> input)
        {
            if (input.Count > 0)
            {
                int countTemp = 0, medianTemp;
                System.Console.WriteLine("De lagrade tempraturerna är:");
                for (int i = 0; i < input.Count; i++)
                {
                    countTemp = countTemp + input[i];
                    System.Console.WriteLine("Tempratur " + (i + 1) + ": " + input[i]);
                }
                medianTemp = countTemp / input.Count;
                return medianTemp;
            }
            else
            {
                System.Console.WriteLine("Det finns inga lagrade mätningar.");
                return 0;
            }
        }
        static void addValue()
        {
            string sTemp = Console.ReadLine();
            try
            {
                int temp = Convert.ToInt32(sTemp);
                weatherData.Add(temp);
            }
            catch
            {
                Console.WriteLine("Du matade inte in en tempratur i siffervärde.");
            }
            return;

        }
        static void removeValue()
        {
            if (weatherData.Count > 0)
            {
                printAll_CountMedian(weatherData);
                Console.WriteLine("Ange vilken mätning du vill ta bort.");
                try
                {

                    int toRemove = Convert.ToInt32(Console.ReadLine());
                    weatherData.RemoveAt(toRemove - 1);
                }
                catch
                {
                    Console.WriteLine("Ange indexplatsen på tepmraturen i siffervärde.");

                }
            }
            else
            {
                Console.WriteLine("Det finns ingen väderdata lagrad.");
            }
            return;
        }
        static void Main(string[] args)
        {

            //Startvärden för att underlätta felsökning.
            // weatherData.Add(23);
            // weatherData.Add(-10);
            // weatherData.Add(14);

            Console.WriteLine("");
            Console.WriteLine("Hej och välkommen till Väderstationen!");
            Console.WriteLine("");

            while (true)
            {
                printMenu();
                //Läser användare input och tar första bokstaven, gör om till ngt programmet förstår.
                //Användaren kan endast mata in bokstäver
                string input = Console.ReadLine().ToUpper();
                char choise = input[0];

                //Hanterar val och kallar funktioner för varige val
                switch (choise)
                {
                    case 'L'://lägg till temp
                        Console.WriteLine("Skriv in tempraturen");
                        addValue();
                        break;
                    case 'S'://skriv ut alla temp och medeltemp
                        int medelvärde = printAll_CountMedian(weatherData);
                        System.Console.WriteLine("Medeltempraturen är: " + medelvärde);
                        break;
                    case 'T'://ta bort temp
                        removeValue();
                        break;
                    case 'A'://avsluta programmet
                        return;
                    default:
                        Console.WriteLine("Jag förstod inte vad du skrev.");
                        break;
                }
            }
        }
    }
}