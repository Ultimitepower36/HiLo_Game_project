// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to Hilo!");


class Game{
    static void Main(string[] args)
    {   
        // Call Dealer from Classes.cs to create Cards (Object)
        // Define the Cards object as the new Dealer Class
        Dealer Cards = new Dealer();
        var ProtoDeck = Cards.Deck();
        var Points = 300;

        while (WinOrLoss())
        {
            var random = new Random();
            int Answer = random.Next(ProtoDeck.Count);
            
        }

        Console.WriteLine("Good game. Thanks for playing!");

    }

    static bool WinOrLoss()
    {   
        return true;
    }
    

}



 
