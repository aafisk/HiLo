class Deck {

    Random rnd = new Random();
    List<int> cards = new List<int>();
    public int currentCard;
    public int nextCard;

    public Deck() {

        //Add four of each card to the deck
        for (int i = 1; i <= 13; i++) 
        {
            for (int x = 1; x <= 4; x++) 
            {
                cards.Add(i);
            }
        }

        //Shuffle the cards after they are all added
        shuffleDeck();

        //Set the current card
        currentCard = drawCard();
    }

    //Randomly changes the position of cards in the list
    public void shuffleDeck() {

        for (int i = 1; i <= 104; i++) 
        {
            int cardIndex1 = rnd.Next(0, cards.Count);
            int cardIndex2 = rnd.Next(0, cards.Count);
            int placeholder = cards[cardIndex1];
            cards[cardIndex1] = cards[cardIndex2];
            cards[cardIndex2] = placeholder;
        }
    }

    //Shuffles the deck and returns the first card in the list
    public int drawCard() {
        shuffleDeck();
        return cards[0];
    }
}

