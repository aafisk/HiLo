class Hilo
{
     static void Main(string[] args)
    {
        Game game = new Game();

        Console.WriteLine("Welcome to HiLo");

        bool loop = true;

        while (loop) {
            game.deck.nextCard = game.deck.drawCard();

            Console.WriteLine($"The card is: {game.deck.currentCard}");

            Console.WriteLine("Higher or lower? [h/l]");
            string playerGuess = Console.ReadLine() ?? "";

            Console.WriteLine($"The card is: {game.deck.nextCard}");

            if (game.checkGuess(playerGuess)) 
            {
                game.score += 100;
            } else 
            {
                game.score -= 75;
            }

            Console.WriteLine($"Your score is {game.score}");

            game.deck.currentCard = game.deck.nextCard;

            Console.WriteLine("Play again? [y/n]");
            string playAgain = Console.ReadLine() ?? "";
            if ((playAgain == "n") || (game.score <= 0))
            {
                loop = false;
            }
        }

        Console.WriteLine("Thanks for playing");
    }

    
}

