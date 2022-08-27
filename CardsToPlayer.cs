namespace DeckOfCards
{
    public class CardsToPlayer
    {
        CardDeck freshDeck = new CardDeck();
        CustomQueue playerQueue = new CustomQueue();
        CustomQueue shuffledCardsQueue = new CustomQueue();
        public int size;

        public void AddPlayer()
        {
            Console.WriteLine("Add Player To Shuffle and distribute the Deck of Cards \n");
            Console.Write("How many player do you want to add : "); size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Player {0} : ", i+1);
                playerQueue.Enqueue(Console.ReadLine().ToUpper());
            }

        }

        public void DistributeCards()
        {
            var uniqueNumbers = new int[52];
            var index = 1;

            while(index < uniqueNumbers.Length)
            {
                var randomNumber = new Random().Next(0, 52);
                if (!uniqueNumbers.Contains(randomNumber))
                {
                    uniqueNumbers[index] = randomNumber;
                    index++;
                }
            }

            foreach (var num in uniqueNumbers)
                shuffledCardsQueue.Enqueue(freshDeck.Deck[num]);
        }

        public void SeeCards()
        {
            var temp = playerQueue.Head;
            var card = shuffledCardsQueue.Head;
            while (temp != null)
            {
                Console.WriteLine("\n >>>>> [+] {0} has following cards with him <<<<< \n", temp.NameOrCard);
                for (int i = 0; i < 52 / size; i++)
                {
                    Console.WriteLine(" {0} ", card.NameOrCard);
                    card = card.Next;
                }
                temp = temp.Next;
            }

        }

    }
}