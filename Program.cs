class Game{
    static void Main(string[] args)
    {   
        // Call Dealer from Classes.cs to create Cards (Object)
        // Define the Cards object as the new Dealer Class
        Console.WriteLine("Welcome to Hilo!");
        Dealer Cards = new Dealer();
        var ProtoDeck = Cards.Deck();
        Dealer Check = new Dealer();
        var Points = 300;
        var Play = true;

        while(Play != false)
        {
            
            // Made New Variable Random into a new Object random
            // New Varible Start will be an integer
            var random = new Random();
            int Start = random.Next(ProtoDeck.Count);
            // Write out Game Options
            Console.WriteLine($"The card is: {Start}");
            Console.WriteLine("Higher or lower? (h/l)");
            // Read inputs from User
            string? input = Console.ReadLine();
            int Next = random.Next(ProtoDeck.Count);

            var TrueOrFalse = WinOrLoss(input, Start, Next);
            Points = Check.Checks(TrueOrFalse, Points);
            Console.WriteLine($"Your score is: {Points}");
            var resulting = GameOver(Points);
            if (resulting == false){
                Play = false;
            }
            else{
                Play = true;
            }
        }
        // Ending script of Code
        Console.WriteLine($"Your final score is {Points}.");
        Console.WriteLine("Good game. Thanks for playing!");

    }

        //Boolean Logic. Determines whether or not Card is Higher or Lower
        // Start is 1st Card Drawn from Deck
        // Input is the User's Guess whether Higher or Lower
        // Next is 2nd Card Drawn from Deck
    static bool WinOrLoss(string input, int Start, int Next)
    {   
        if ((Next > Start) && (input == "h")){
            return true;
        }
        else if ((Next > Start) && (input == "l")){
            return false;
        }
        else if ((Next < Start) && (input == "h")){
            return false;
        }
        else if ((Next < Start) && (input == "l")){
            return true;
        }
        else{
            Console.WriteLine("Both numbers were the same, you win by default.");
            return true;
        }
    }

        // Determinmes how many points the User has
        // Also determines if they would like to stop playing
        // Points is How many total Points the user has
    static bool GameOver(int Points)
    {
        if (Points <= 0){
            return false;
        }
        else{
            Console.WriteLine("Do you want to play again? (y/n)");
            string? input = Console.ReadLine();
            if (input == "y"){
                return true;
            }
            else if (input == "n"){
                return false;
            }
            else{
                return true;
            } 
        }

    }
    

}