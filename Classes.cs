class Dealer {

    List<int> spaces = new List<int>();
    

    public List<int> Deck() {
        spaces = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13};
        return spaces;
    }

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