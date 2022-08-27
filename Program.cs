namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var UI = new CardsToPlayer();
            UI.AddPlayer();
            UI.DistributeCards();
            UI.SeeCards();
        }
    }
}