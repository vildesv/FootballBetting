using System;

namespace FootballBetting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();
            var match = new Match(bet);
            while (match.IsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine();
                if (command == "X") match.Stop();
                else if (command == "H" || command == "B") match.AddGoal(command == "H");
                Console.WriteLine($"Stillingen er {match.GetScore()}.");
            }

            var isBetCorrectText = match.IsBetCorrect() ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");

            /* Gammel kode fra løsningsforslag: 
             
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();
            var homeGoals = 0;
            var awayGoals = 0;
            var matchIsRunning = true;
            while (matchIsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine();
                matchIsRunning = command != "X";
                if (command == "H") homeGoals++;
                else if (command == "B") awayGoals++;
                Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
            }
            var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
            var isBetCorrect = bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");

            */
        }
    }
}
