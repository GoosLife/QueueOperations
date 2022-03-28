using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueOperations
{
    public class Card
    {
        public string Name { get; set; }

        public Card(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
