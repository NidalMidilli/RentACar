using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICardService
    {
        void AddToCard(Card card, Car car);
        void RemoveFromCard(Card card, int carId);
        List<CardLine> List(Card card);
    }
}
