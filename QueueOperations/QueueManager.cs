using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueOperations
{
    public class QueueManager
    {
        Queue<Card> cards = new Queue<Card>();

        public QueueManager()
        {
            Card firstCard = new Card("Card1");
            Card secondCard = new Card("Card2");
            Card thirdCard = new Card("Card3");
            Card fourthCard = new Card("Card4");

            cards.Enqueue(firstCard);
            cards.Enqueue(secondCard);
            cards.Enqueue(thirdCard);
            cards.Enqueue(fourthCard);
        }

        public void AddItems(string name)
        {
            Card card = new Card(name);
            cards.Enqueue(card);
        }

        public string DeleteItems()
        {
            return cards.Dequeue().ToString();
        }

        public string ShowItems()
        {
            string output = "";

            foreach (Card c in cards)
            {
                output += c.ToString();
            }

            return output;
        }

        public string ShowFirstAndLast()
        {
            string output = "";
            // Maybe copy to array?
        }
    }
}
