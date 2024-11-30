using Backend1.Models;
using Backend1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Backend1.Controllers
{
    public class CalcServiceController : Controller
    {
        public IActionResult PassUsingViewData()
        {
            Random rnd = new Random();

            int firstValue = rnd.Next(0, 11);
            int secondValue = rnd.Next(0, 11);

            ViewData["FirstValue"] = firstValue;
            ViewData["SecondValue"] = secondValue;
            ViewData["Add"] = firstValue + secondValue;
            ViewData["Sub"] = firstValue - secondValue;
            ViewData["Mult"] = firstValue * secondValue;
            ViewData["Div"] = (secondValue != 0) ? ((float)firstValue / secondValue).ToString() : "Деление на 0";

            return View();
        }
        public IActionResult PassUsingViewBag()
        {
            Random rnd = new Random();

            int firstValue = rnd.Next(0, 11);
            int secondValue = rnd.Next(0, 11);

            ViewBag.FirstValue = firstValue;
            ViewBag.SecondValue = secondValue;
            ViewBag.Add = firstValue + secondValue;
            ViewBag.Sub = firstValue - secondValue;
            ViewBag.Mult = firstValue * secondValue;
            ViewBag.Div = (secondValue != 0) ? ((float)firstValue / secondValue).ToString() : "Деление на 0";


            return View();
        }
        public IActionResult PassUsingModel()
        {
            CalcModel calcModel = new CalcModel();
            CalcViewModel viewModel = new CalcViewModel();

            viewModel.FirstValue = calcModel.FirstValue.ToString();
            viewModel.SecondValue = calcModel.SecondValue.ToString();

            viewModel.AddValue = calcModel.CalcAdd().ToString();
            viewModel.SubValue = calcModel.CalcSub().ToString();
            viewModel.MultValue = calcModel.CalcMult().ToString();

            viewModel.DivValue = (calcModel.SecondValue != 0) ? calcModel.CalcDiv().ToString() : "Деление на 0";

            return View(viewModel);
        }
        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}
