using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Card
    {
        public Card()
        {
            CardLines = new List<CardLine>();
        }
        public List<CardLine> CardLines { get; set; }

        public decimal Total
        {
            get
            {
                return CardLines.Sum(x => x.Car.Price * x.Quantity);
            }
        }
    }
}
