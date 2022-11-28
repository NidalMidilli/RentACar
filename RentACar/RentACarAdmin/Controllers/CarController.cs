using BusinessLayer.Abstract;
using BusinessLayer.Validations;
using DataAccess.Concrete;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RentACarAdmin.Controllers
{
    public class CarController : Controller
    {
        ICarService carService;
        Context con = new Context();
        public CarController(ICarService carService)
        {
            this.carService = carService;
        }
        [Authorize(Roles ="admin")]
        public IActionResult Index()
        {
            var result = carService.GetCarWithModels();
            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Car car)
        {
            CarValidator carValidator = new CarValidator();
            ValidationResult results = carValidator.Validate(car);
            if (results.IsValid)
            {
                carService.AddCar(car);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = carService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(Car car)
        {
            CarValidator carValidator = new CarValidator();
            ValidationResult results = carValidator.Validate(car);
            if (results.IsValid)
            {
                carService.UpdateCar(car);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = con.Cars.FirstOrDefault(x => x.carId == id);
            carService.DeleteCar(result);
            return RedirectToAction("Index");
        }

    }
}
