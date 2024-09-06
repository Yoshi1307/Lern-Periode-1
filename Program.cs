class Program
{
    static void Main()
    {

        Console.WriteLine("Bitte wählen Sie einen Fussballer:");
        Console.WriteLine("1. Cristiano Ronaldo");
        Console.WriteLine("2. Lamine Yamal");
        Console.WriteLine("3. Yann Sommer");
        Console.WriteLine("4. Lionel Messi");


        Console.Write("Ihre Auswahl (1-4): ");
        string auswahl = Console.ReadLine();


        int FussballerGrösse;


        switch (auswahl)
        {
            case "1":
                FussballerGrösse = 187;
                break;
            case "2":
                FussballerGrösse = 178;
                break;
            case "3":
                FussballerGrösse = 183;
                break;
            case "4":
                FussballerGrösse = 170;
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
                Console.WriteLine("Bitte geben Sie eine gültige Zahl als Grösse ein.");
            else


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
            Console.WriteLine("Bitte geben Sie eine gültige Zahl als Grösse ein.");

            Console.Write("Bitte geben Sie Ihre Grösse ein: ");

            Console.ReadLine();

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

    }


}
