using System;
using System.Collections.Generic;
/* 
    Nu ska det gå att välja mellan olika städer i programmet. 
    Vilka städer som finns eller hur många är inte förutbestämt
    Användaren ska själv via en meny kunna välja eller lägga till en stad.
    När användaren lägger till en stad får hen ange namn på staden och temperaturen. 
    Via menyn kan man sedan kontrollera temperatur för alla städer, 
    medeltemperaturen samt var det är varmast och var det är kallast. 
*/

namespace weatherstation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> städer = new List <string>();
            Console.WriteLine("Välkommen till väderstationen!");
            while(true){
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("");
                Console.WriteLine("Lägg till stad");
                Console.WriteLine("Byt tempratur på stad");
                Console.WriteLine("Medeltempratur på städer");
                Console.WriteLine("Kallast stad");
                Console.WriteLine("Varmast stad");
                Console.WriteLine("Avsluta programmet");
                
                string input = Console.ReadLine();
                char choise = input[0];
                switch(choise){
                    case 'L'://Lägg till stad
                        break;
                    case 'B'://Byt temp
                        break;
                    case 'M'://Medeltemp
                        break;
                    case 'K'://Kallast Temp
                        break;
                    case 'V'://Varmast temp
                        break;
                    default://Felhantering
                        Console.WriteLine("Ange endast det som står i menyn");
                        break;
                    case 'A'://Avsluta programmet
                        return;
                }
            }
        }
    }
}
