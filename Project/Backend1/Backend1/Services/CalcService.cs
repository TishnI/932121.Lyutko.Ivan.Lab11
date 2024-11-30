namespace Backend1.Services
{
    public class CalcService : ICalcService
    {
        public CalcService()
        {
            Random random = new Random();
            firstValue = random.Next(0, 11);
            secondValue = random.Next(0, 11);
        }

        private int firstValue;
        private int secondValue;

        public string GetFirstValue()
        {
            return firstValue.ToString();
        }
        public string GetSecondValue()
        {
            return secondValue.ToString();
        }

        public string GetAdd()
        {
            return (firstValue + secondValue).ToString();
        }

        public string GetDiv()
        {
            return (secondValue != 0) ? ((float)firstValue / secondValue).ToString() : "Деление на 0";
        }

        public string GetMult()
        {
            return (firstValue * secondValue).ToString();
        }

        public string GetSub()
        {
            return (firstValue - secondValue).ToString();
        }
    }
}
