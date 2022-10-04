class Dealer {

    List<int> spaces = new List<int>();
    
    // Deck creater. 
    // Determines Which numbers are drawn from the deck
    // Determines the Random 2nd number from the deck 

    // Problems
    // Make sure we have a long enough list
    public List<int> Deck() {
        spaces = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13};
        return spaces;
    }

    // Checks whether the User Gains or Loses Points
    // Determines how many points the users has

    // Problems
    // None yet
    public void Checks(bool TrueOrFalse, int Points) {
        if (TrueOrFalse == true){
            Points += 100;
        }
        else if (TrueOrFalse == false){
            Points -= 75;
        }
        return;
    }
}