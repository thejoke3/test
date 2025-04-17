namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 3 9 5 1 9 7 4 9  

            int[] r = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            int BigestNum = 0;
            int count = 0;

            for (int i = 0; i < r.Length; i++)
            {
                sum = sum + r[i];

                if (r[i] > BigestNum)
                {
                    BigestNum = r[i];

                }

            }

            for (int i = 0; i < r.Length; i++)
            {
                if (r[i] == 9)
                {
                    count++;
                }
            }

            Console.WriteLine($"Сума на елементи: {sum}");
            Console.WriteLine($"Най-голям елемент: {BigestNum}");
            Console.WriteLine($"Числото 9 се среща {count} пъти");
        }
    }
}
