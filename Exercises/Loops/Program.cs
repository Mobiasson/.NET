class Loops
{
    /* 1. Skriv talen 20 till 30 */
    static void Exercise1()
    {
        for (int i = 20; i <= 30; i++)
        {
            Console.WriteLine(i);
        }
    }

    /* 2. Jämna tal */
    static void Exercise2()
    {
        for (int i = 0; i <= 30; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    // 3. Var tredje "Hej"
    static void Exercise3()
    {
        for (int i = 0; i <= 30; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("Hej");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Write 'q' to exit");
            Console.WriteLine("1. Skriv tal 20 till 30");
            Console.WriteLine("2. Jämna tal");
            Console.WriteLine("3. Var tredje 'Hej'");
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    break;
                case "1":
                    Exercise1();
                    break;
                case "2":
                    Exercise2();
                    break;
                case "3":
                    Exercise3();
                    break;
                case "q":
                    Console.WriteLine("Exiting program");
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again!");
                    break;
            }
        }
    }
}
