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

        public string ShowNumberOfItems()
        {
            return cards.Count.ToString();
        }

        public string ShowFirstAndLast()
        {
            string output = "";

            Card[] cardArr = cards.ToArray();

            output += cardArr[0];
            output += "\n";
            output += cardArr[cardArr.Length - 1];

            return output;
        }

        public string FindItem(string searchQuery)
        {
            string output = "";
            List<Card> matches = cards.Where(c => c.Name.Contains(searchQuery)).ToList();
            
            if (matches.Count > 0)
            {
                foreach (Card c in matches)
                {
                    output += c + "\n";
                }
            }
            else
            {
                return "No matches found";
            }
            
            return output;
        }

        public string PrintAllItems()
        {
            string output = "";

            foreach (Card c in cards)
            {
                output += c + "\n";
            }

            return output;
        }
    }
}
