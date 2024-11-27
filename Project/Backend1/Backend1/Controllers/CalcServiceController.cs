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

            if(secondValue == 0)
            {
                ViewData["Div"] = "ERROR!";
            }
            else
            {
                ViewData["Div"] = (float)firstValue / secondValue;
            }

            return View();
        }
    }
}
