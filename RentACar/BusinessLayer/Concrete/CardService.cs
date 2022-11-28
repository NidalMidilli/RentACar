using BusinessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CardService : ICardService
    {
        public void AddToCard(Card card, Car car)
        {
            CardLine cline = card.CardLines.FirstOrDefault(x => x.Car.carId == car.carId);
            if(cline != null)
            {
                cline.Quantity++;
                return;
            }
            else
            {
                card.CardLines.Add(new CardLine { Car = car, Quantity = 1 });
            }
        }

        public List<CardLine> List(Card card)
        {
            return card.CardLines;
        }

        public void RemoveFromCard(Card card, int carId)
        {
            card.CardLines.Remove(card.CardLines.FirstOrDefault(x=>x.Car.carId == carId));
        }
    }
}
