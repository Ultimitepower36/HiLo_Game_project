// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to Hilo!");


class Game{
    static void Main(string[] args)
    {
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



 
