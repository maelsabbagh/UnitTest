namespace Sparky
{
    public class Calculator
    {
        public List<int> NumberRange;

        public Calculator()
        {
            NumberRange = new List<int>();
        }
        public int AddNumber(int a , int b)
        {
            return a + b;
        }

        public bool isOddNumber(int num)
        {
            return num % 2 != 0;
        }

        public List<int>getOddRange(int min,int max)
        {
            NumberRange.Clear();

            for(int i=min;i<=max;i++)
            {
                if(i%2!=0)
                {
                    NumberRange.Add(i);
                }
            }
            return NumberRange;
        }
    }
}
