namespace Calculator
{
    public class CalculatorForTest
    {
        public List<int>? Numbers = new List<int>();

        public int add(int a , int b)
        {
            return (a + b);
        }

        public double addDobule(double a, double b)
        {
            return (a + b);
        }   

        public List<int> OddNumbers(int min,int max)
        {
            Numbers?.Clear();

            for(int i = min; i <= max; i++)
            {
                if (i % 2 != 0)
                {
                    Numbers?.Add(i);
                }
            }


            return Numbers;
        }
    }
}
