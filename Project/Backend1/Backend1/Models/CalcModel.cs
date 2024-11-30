namespace Backend1.Models
{
    public class CalcModel
    {
        public int FirstValue { get; private set; }
        public int SecondValue { get; private set; }

        public CalcModel()
        {
            Random random = new Random();
            FirstValue = random.Next(0, 11);
            SecondValue = random.Next(0, 11);
        }

        public float CalcAdd()
        {
            return FirstValue + SecondValue;
        }
        public float CalcSub()
        {
            return FirstValue - SecondValue;
        }
        public float CalcMult()
        {
            return FirstValue * SecondValue;
        }
        public float CalcDiv()
        {

            return (float)FirstValue / SecondValue;
        }
    }
}
