class Game {

    public int score;
    public Deck deck = new Deck();
    
    public Game() {
        score = 300;
    }

    public bool checkGuess(string guess) {
        return (((deck.currentCard > deck.nextCard) && (guess == "l")) 
            || ((deck.currentCard < deck.nextCard) && (guess == "h")));
    }
}