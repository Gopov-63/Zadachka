namespace Zadachen
{
    class Program
    {
        static void Main()
        {
            int choice;

            Console.WriteLine("===== ZADACHI SA SPISACI =====");
            Console.WriteLine("1. Namirane na nai-golyam element");
            Console.WriteLine("2. Premahvane na vsichki chetni chisla");
            Console.WriteLine("3. Obrastane na spisaka");
            Console.WriteLine("4. Vtorata po golemina stoinost");
            Console.WriteLine("5. Proverka dali element sushtestvuva");
            Console.Write("Izberi zadacha: ");

            choice = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int> { 5, 12, 3, 8, 20, 7 };

            // 1. Най-голям елемент
            if (choice == 1)
            {
                int max = numbers[0];

                foreach (int number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }

                Console.WriteLine("Nai-golemiyat element e: " + max);
            }

            // 2. Премахване на всички четни числа
            else if (choice == 2)
            {
                numbers.RemoveAll(number => number % 2 == 0);

                Console.Write("Spisak bez chetni chisla: ");

                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
