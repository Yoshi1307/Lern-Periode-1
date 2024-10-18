using System;

class Program
{
    static void Main()
    {
        
        string soccerPlayer1Name = "Cristiano Ronaldo";
        int soccerPlayer1Height = 187;
        string soccerPlayer1Fact = "Ronaldo ist der Fussballspieler mit den meisten Toren, ganze 900.";

        string soccerPlayer2Name = "Lamine Yamal";
        int soccerPlayer2Height = 178;
        string soccerPlayer2Fact = "Lamine Yamal ist der jüngste Spieler, der jemals die EM gewann, mit 17 Jahren und 1 Tag.";

        string soccerPlayer3Name = "Yann Sommer";
        int soccerPlayer3Height = 183;
        string soccerPlayer3Fact = "Yann Sommer ist einer der besten Torhüter der Welt, obwohl er einer der kleinsten auf seiner Position ist.";

        string soccerPlayer4Name = "N’Golo Kanté";
        int soccerPlayer4Height = 168;
        string soccerPlayer4Fact = "N’Golo Kanté ist einer von sehr wenigen Fussballern, die es geschafft haben 2 Premier League Titel mit 2 verschiedenen Vereinen Nacheinander zu gewinnen.";

        bool repeat = true; 

        while (repeat)
        {
            Console.WriteLine("Bitte wählen Sie einen Fussballer:");
            Console.WriteLine("1. " + soccerPlayer1Name);
            Console.WriteLine("2. " + soccerPlayer2Name);
            Console.WriteLine("3. " + soccerPlayer3Name);
            Console.WriteLine("4. " + soccerPlayer4Name);

            Console.Write("Ihre Auswahl (1-4): ");
            string selection = Console.ReadLine();

            int selectedPlayerHeight = 0;
            string selectedPlayerFact = "";

            switch (selection)
            {
                case "1":
                    selectedPlayerHeight = soccerPlayer1Height;
                    selectedPlayerFact = soccerPlayer1Fact;
                    break;
                case "2":
                    selectedPlayerHeight = soccerPlayer2Height;
                    selectedPlayerFact = soccerPlayer2Fact;
                    break;
                case "3":
                    selectedPlayerHeight = soccerPlayer3Height;
                    selectedPlayerFact = soccerPlayer3Fact;
                    break;
                case "4":
                    selectedPlayerHeight = soccerPlayer4Height;
                    selectedPlayerFact = soccerPlayer4Fact;
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl. Das Programm wird beendet.");
                    return;
            }

            Console.WriteLine("");
            Console.WriteLine($"Fakt über den Spieler: {selectedPlayerFact}");
            Console.WriteLine("");
            Console.Write("Bitte geben Sie Ihre Grösse ein: ");

            string Input = Console.ReadLine();

            if (int.TryParse(Input, out int UserHeight))
            {
                if (UserHeight > 210 || UserHeight < 130)
                {
                    Console.WriteLine("Bitte geben Sie eine gültige Zahl als Grösse ein.");
                }
                else
                {
                    if (UserHeight > selectedPlayerHeight)
                    {
                        Console.WriteLine("Sie sind grösser als die bekannte Person.");
                    }
                    else if (UserHeight < selectedPlayerHeight)
                    {
                        Console.WriteLine("Sie sind kleiner als die bekannte Person.");
                    }
                    else
                    {
                        Console.WriteLine("Sie sind genauso gross wie die bekannte Person.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe, bitte geben Sie eine Zahl ein.");
            }

            Console.WriteLine("");
            Console.Write("Möchten Sie noch einmal von vorne beginnen? (ja/nein): ");
            string response = Console.ReadLine().ToLower();

            if (response != "ja")
            {
                repeat = false; 
            }
            Console.WriteLine();
        }
    }
}

