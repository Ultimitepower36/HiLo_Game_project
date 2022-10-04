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

        while (!WinOrLoss())
        {
           
        }

        Console.WriteLine("Good game. Thanks for playing!");

    }

    static bool WinOrLoss()
    {
        
        return true;
    }
    

}



 
