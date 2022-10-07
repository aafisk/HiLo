class Game {

    public int score;
    public Deck deck = new Deck();
    
    public Game() {
        score = 300;
    }

    //Checks if the next card is higher or lower than the current card
    //and checks if the user made the correct guess. Returns a boolean.
    public bool checkGuess(string guess) {
        return (((deck.currentCard > deck.nextCard) && (guess == "l")) 
            || ((deck.currentCard < deck.nextCard) && (guess == "h")));
    }
}