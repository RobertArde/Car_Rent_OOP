using System;
using System.Collections;

namespace Car_Rent_OOP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int eingabe;
            int i = 0;
            ArrayList someList = new ArrayList();
            string farbe, marke;
            int km;
            double preis;

            while (true)
            {

                Console.WriteLine("MENUE:");
                Console.WriteLine("1) Neues Auto hinzufügen ");
                Console.WriteLine("2) Auto löschen ");
                Console.WriteLine("3) Auto besetzen/freigeben");
                Console.WriteLine("4) Alle Autos anzeigen ");
                Console.WriteLine("5) Alle freien Autos anzeigen");
                Console.WriteLine("6) Programm schliessen");

                eingabe = Convert.ToInt32(Console.ReadLine());
                

                switch (eingabe)
                {
                    case (1):
                        Add_Car(out farbe, out marke,out km,out preis);
                        someList.Add(new Car(farbe,marke,km,preis,true));
                        i++;
                            break;

                    case (2):
                        int x;
                        Console.WriteLine("Welches Auto wollen Sie löschen?: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        someList.Remove(x);
                        break;
                    case (3):
                        int y;
                        Console.WriteLine("Welches Auto wollen Sie besetzen/freigeben?");
                        y = Convert.ToInt32(Console.ReadLine());
                        
                        break;
                    default:
                        break;
                }

                
            }

        }

        static void Add_Car(out string farbe, out string marke, out int km, out double preis)
        {
            Console.WriteLine("Farbe: ");
            farbe = Console.ReadLine();

            Console.WriteLine("Marke: ");
            marke = Console.ReadLine();

            Console.WriteLine("Kilometerstand: ");
            km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Preis pro Tag: ");
            preis = Convert.ToDouble(Console.ReadLine());
        }
        
    }
}
