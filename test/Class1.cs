namespace test
{
    public class OurClassLibrary
    {
        public static double SumEven(double[] mas)
        {
            double sum = 0;
            for (int i = 0; i < mas.Length; i += 2) sum += mas[i];
            return sum;
        }
    }
}
