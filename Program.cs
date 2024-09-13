using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Bitte wählen Sie einen Fussballer:");
        Console.WriteLine("1. Cristiano Ronaldo");
        Console.WriteLine("2. Lamine Yamal");
        Console.WriteLine("3. Yann Sommer");
        Console.WriteLine("4. Lionel Messi");

        int FussballerGrösse;
        string Fakt;



        switch (auswahl)
        {
            case "1":
                FussballerGrösse = 187;
                Fakt = "Ronaldo ist der Fussballspieler mit den meisten Toren, ganze 900";
                break;
            case "2":
                FussballerGrösse = 178;
                Fakt = "Lamine Yamal ist der Jüngste Spieler, der jemals die EM gewann mit 17 Jahren und 1 Tag";
                break;
            case "3":
                FussballerGrösse = 183;
                Fakt = "Yann Sommer ist einer der besten Torhüter der Welt, obwohl er einer der kleinsten auf seiner Posizion ist";
                    break;
            case "4":
                FussballerGrösse = 170;
                Fakt = "Lionel Messi ist der spieler mit den meisten Ballon d'ors";
                break;
            default:
                Console.WriteLine("Ungültige Auswahl. Das Programm wird beendet.");
                return;
        }

        Console.Write("Bitte geben Sie Ihre Grösse ein: ");
        string eingabe = Console.ReadLine();


        if (int.TryParse(eingabe, out int benutzerGrösse))
        {
            if (benutzerGrösse > 210 || benutzerGrösse < 130)
            {
                Console.WriteLine("Bitte geben Sie eine gültige Zahl als Grösse ein.");
                return;
            }



            if (benutzerGrösse > FussballerGrösse)
            {
                Console.WriteLine("Sie sind grösser als die bekannte Person.");
            }
            else if (benutzerGrösse < FussballerGrösse)
            {
                Console.WriteLine("Sie sind kleiner als die bekannte Person.");
            }
            else if (benutzerGrösse == FussballerGrösse) 
            {
                Console.WriteLine("Sie sind genauso gross wie die bekannte Person.");
            }
        }
        else
        {
                Console.WriteLine("Ungültige Eingabe, bitte geben sie eine Zahl ein: ");
        }
    }
}    


