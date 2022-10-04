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
        Dealer Check = new Dealer();
        var X = Check.Checks();
        var Points = 300;

        while (GameOver())
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
            Points = Cards.Checks(TrueOrFalse, Points);
            GameOver(Points);
        }
        // Ending script of Code
        Console.WriteLine($"Your final score is {Points}.");
        Console.WriteLine("Good game. Thanks for playing!");

    }

        //Boolean Logic. Determines whether or not Card is Higher or Lower
        // Start is 1st Card Drawn from Deck
        // Input is the User's Guess whether Higher or Lower
        // Next is 2nd Card Drawn from Deck

        // Probelms
        // Define H and L 
    static bool WinOrLoss(string input, int Start, int Next)
    {   
        if ((Next > Start) && (input = 'h')){
            return true;
        }
        else if ((Next > Start) && (input = 'l')){
            return false;
        }
        else if ((Next < Start) && (input = 'h')){
            return false;
        }
        else if ((Next < Start) && (input = 'l')){
            return true;
        }
        else if (Next == Start){
            Console.WriteLine("Both numbers were the same, you win by default.");
            return true;
        }
    }

        // Determinmes how many points the User has
        // Also determines if they would like to stop playing
        // Points is How many total Points the user has


        // Problems
        // Y and N determine whether or not to continue
    static bool GameOver(int Points)
    {
        if (Points <= 0){
            return false;
        }
        else if(Points > 0){
            Console.WriteLine("Do you want to play again? (y/n)");
            string? input = Console.ReadLine();
            if (input = 'y'){
                return true;
            }
            else if (input = 'n'){
                return false;
            }
            else{
                return true;
            } 
        }

    }
    

}

/*
Individual cards are represented as a number from 1 to 13.
The current card is displayed.
The player guesses if the next one will be higher or lower.
The the next card is displayed.
The player earns 100 points if they guessed correctly.
The player loses 75 points if they guessed incorrectly.
If a player reaches 0 points the game is over.
If a player has more than 0 points they decide if they want to keep playing.
If a player decides not to play again the game is over.
*/



 
