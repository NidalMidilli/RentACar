using EntityLayer;

namespace RentACarUI.Services
{
    public interface ICardSessionService
    {
        Card GetCard();
        void SetCard(Card card);
    }
}
