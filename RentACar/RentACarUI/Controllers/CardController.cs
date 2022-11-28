using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using RentACarUI.Models;
using RentACarUI.Services;
using System;

namespace RentACarUI.Controllers
{
    public class CardController : Controller
    {
        private ICardSessionService sessionService;
        private ICardService cardService;
        private ICarService carService;

        public CardController(ICardSessionService sessionService, ICardService cartService, ICarService carService)
        {
            this.sessionService = sessionService;
            this.cardService = cartService;
            this.carService = carService;
        }
        public ActionResult AddToCard(int carId)
        {
            var carToBeAdded = carService.GetById(carId);
            var card = sessionService.GetCard();
            cardService.AddToCard(card, carToBeAdded);
            sessionService.SetCard(card);
            //TempData.Add("message", String.Format("Ürün, {0}, başarılı bir şekilde eklendi", productToBeAdded.productName));
            return RedirectToAction("Index", "Car");
        }

        public ActionResult List()
        {
            var card = sessionService.GetCard();

            CardListViewModel cardListViewModel = new CardListViewModel
            {
                Card = card
            };

            return View(cardListViewModel);
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Remove(int carId)
        {
            var card = sessionService.GetCard();
            cardService.RemoveFromCard(card, carId);
            sessionService.SetCard(card);
            TempData.Add("message", String.Format("Ürün, başarılı bir şekilde silindi"));
            return RedirectToAction("List");
        }
    }
}
