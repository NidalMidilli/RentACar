using EntityLayer;
using Microsoft.AspNetCore.Http;
using RentACarUI.SessionExtensionMethod;

namespace RentACarUI.Services
{
    public class CardSessionService:ICardSessionService
    {
        IHttpContextAccessor _httpContextAccessor;
        public CardSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Card GetCard()
        {
            Card cardToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Card>("card");
            if (cardToCheck == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("card", new Card());
                cardToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Card>("card");
            }
            return cardToCheck;
        }

 

        public void SetCard(Card card)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("card", card);
        }

      
    }
}
