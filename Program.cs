namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Print("Введите сообщение", true);
            var str = Console.ReadLine();
            Print("Введите глубину", true);
            int deep = int.Parse(Console.ReadLine());
            Deep(str, deep);
            Console.ReadKey();
        }

        private static void Deep(string str, int deep)
        {
            BackColor();
            Print(". . ." + str, true);
            if (str.Length > 2)
            {
                if (deep > 1)
                {
                    Deep(str.Remove(0, 2), deep - 1);
                }
            }
        }

        private static void BackColor()
        {
            Random random = new Random();
            switch (random.Next(0, 5))
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 1:
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
            }
        }

        private static void Print(string message, bool ifWriteLine)
        {
            if (ifWriteLine)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.Write(message);
            }
        }
    }
}