class Hilo
{
     static void Main(string[] args)
    {
        Game game = new Game();

        Console.WriteLine("Welcome to HiLo");

        bool loop = true;

        //Main game loop
        while (loop) {

            //Get next card
            game.deck.nextCard = game.deck.drawCard();

            //Display current card
            Console.WriteLine($"The card is: {game.deck.currentCard}");

            //Prompt the user for a guess
            Console.WriteLine("Higher or lower? [h/l]");
            string playerGuess = Console.ReadLine() ?? "";

            //Display next card, check if the guess is correct, adjust score accordingly
            Console.WriteLine($"The card is: {game.deck.nextCard}");
            if (game.checkGuess(playerGuess)) 
            {
                game.score += 100;
            } else 
            {
                game.score -= 75;
            }

            Console.WriteLine($"Your score is {game.score}");

            //Prepare next card if the player chooses to play again
            game.deck.currentCard = game.deck.nextCard;

            //Ask the user if they want to play again and end loop accordingly
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

