class Deck {

    Random rnd = new Random();
    List<int> cards = new List<int>();
    int currentCard;
    int nextCard;

    public Deck() {

        //Add four of each card to the deck
        for (int i = 1; i <= 13; i++) 
        {
            for (int x = 1; x <= 4; x++) 
            {
                cards.Add(i);
            }
        }

        shuffleDeck();

        currentCard = drawCard();
        nextCard = drawCard();
    }

    public void shuffleDeck() {

        for (int i = 1; i <= 104; i++) 
        {
            int cardIndex1 = rnd.Next(1, cards.Count + 1);
            int cardIndex2 = rnd.Next(1, cards.Count + 1);
            int placeholder = cards[cardIndex1];
            cards[cardIndex1] = cards[cardIndex2];
            cards[cardIndex2] = placeholder;
        }
    }

    public int drawCard() {
        shuffleDeck();
        return cards[0];
    }
}

