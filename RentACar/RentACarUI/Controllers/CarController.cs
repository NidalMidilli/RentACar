using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using RentACarUI.Models;

namespace RentACarUI.Controllers
{
    public class CarController : Controller
    {
        private ICarService carService;

        public CarController(ICarService carService)
        {
            this.carService = carService;
        }
        public IActionResult Index()
        {
            CarListViewModel model = new CarListViewModel
            {

                Cars = carService.ListAllCars()
            };
            return View(model);
        }
        }
    }

