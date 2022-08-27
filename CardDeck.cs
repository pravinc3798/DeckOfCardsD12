namespace DeckOfCards
{
    public class CardDeck
    {
        public string[] Suit = { "Clubs", "Daimonds", "Hearts", "Spade" };
        public string[] Rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        public string[] Deck = new string[52];

        public CardDeck()
        {
            var counter = 0;
            foreach (var s in Suit)
                foreach (var r in Rank)
                {
                    Deck[counter] = String.Format("{0} of {1}", r, s);
                    counter++;
                }
        }
    }
}