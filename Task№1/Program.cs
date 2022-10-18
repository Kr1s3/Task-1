internal class Program
{
    private static void Main(string[] args)
    {
        static double random()
        {
            Random rnd = new Random();
            double rand = rnd.Next(-1000, 1000);
            return rand / 100;
        }

        double[] array = new double[10];
        for (int i = 0; i < 10; i++)
        {
            array[i] = random();
        }

        double temp;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        Console.WriteLine($"Максимальное число:{Convert.ToString(array[array.Length - 1])}");

        Console.WriteLine($"Минимальное число:{Convert.ToString(array[0])}");

    }
}
    