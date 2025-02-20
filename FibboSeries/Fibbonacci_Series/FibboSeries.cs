namespace Fibbonacci_Series;

public class FibboSeries
{
    public List<int> ints = new List<int>();

    public List<int> GetFibbonacci(int number)
    {
        int a = 1;
        int b = 1;

        if (number <= 0)
            throw new ArgumentException("Number must be greater than 0");

        if (number == 1)
            ints.Clear();
            ints.Add(a); 
        
        if (number >= 2)
        {
            ints.Clear();   
            ints.Add(a);
            ints.Add(b);

            for (int i = 2; i < number; i++)
            {
                int c = a + b;
                ints.Add(c);
                a = b;
                b = c;
            }
        }
           
        return ints;
    }

}
