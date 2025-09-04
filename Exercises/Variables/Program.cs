using System;

class Exercises
{
    // 1. Hälsa på användaren
    static void Exercise1()
    {
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello, your name is {name}");
    }

    // 2. Multiplicera två tal
    static void Exercise2()
    {
        Console.WriteLine("Write a random number");
        string? firstInput = Console.ReadLine();
        Console.WriteLine("Write another random number");
        string? secondInput = Console.ReadLine();
        if (int.TryParse(firstInput, out int value1) && int.TryParse(secondInput, out int value2))
        {
            int product = value1 * value2;
            Console.WriteLine($"{value1} * {value2} = {product}");
        }
        else
        {
            Console.WriteLine("Invalid input, please enter valid integers.");
        }
    }

    // 3. Verifiera lösenord
    static void Exercise3()
    {
        string password = "abc123";
        Console.WriteLine("Skriv in ett lösenord");
        string? input = Console.ReadLine();
        while (password != input)
        {
            Console.WriteLine("Wrong password! Try again!");
            input = Console.ReadLine();
        }
        Console.WriteLine("Correct!");
    }

    // 4. Jämför tal
    static void Exercise4()
    {
        int target = 100;
        Console.WriteLine("Guess the number");
        string? guess = Console.ReadLine();
        int value = int.TryParse(guess, out int result) ? result : 0;

        while (value != target)
        {
            if (value > target)
                Console.WriteLine("That is too high");
            else if (value < target)
                Console.WriteLine("That is too low");

            Console.WriteLine("Guess again!");
            guess = Console.ReadLine();
            value = int.TryParse(guess, out result) ? result : 0;
        }
        Console.WriteLine("Correct!");
    }

    // 5. Dubblera och halvera tal
    static void Exercise5()
    {
        Console.WriteLine("Write a random number");
        string? number = Console.ReadLine();
        int digits = int.TryParse(number, out int result2) ? result2 : 0;

        int timesTwo = digits * 2;
        Console.WriteLine($"{timesTwo} is the double of {digits}");

        int half = digits / 2;
        Console.WriteLine($"{half} is the half of {digits}");
    }

    // 6. Miniräknare
    static void Exercise6()
    {
        Console.WriteLine("Write a number 1-9");
        string? firstInput = Console.ReadLine();
        string? operatorInput;
        Console.WriteLine("Enter an operator: '+', '-', '*' or '/'");
        do
        {
            operatorInput = Console.ReadLine();
            if (operatorInput is "+" or "-" or "*" or "/")
                break;
            Console.WriteLine("Invalid operator! Please enter '+', '-', '*' or '/'.");
        } while (true);

        Console.WriteLine($"{firstInput} {operatorInput} enter another number");
        string? secondInput = Console.ReadLine();
        int num1 = int.TryParse(firstInput, out int result) ? result : 0;
        int num2 = int.TryParse(secondInput, out int result2) ? result2 : 0;
        if (operatorInput == "+")
        {
            Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
            Console.WriteLine("Press any key to get back to the menu....");
            Console.ReadKey();
        }
        else if (operatorInput == "-")
        {
            Console.WriteLine($"{num1} - {num2} is {num1 - num2}");
            Console.WriteLine("Press any key to get back to the menu....");
            Console.ReadKey();
        }
        else if (operatorInput == "*")
        {
            Console.WriteLine($"{num1} x {num2} equals {num1 * num2}");
            Console.WriteLine("Press any key to get back to the menu....");
            Console.ReadKey();
        }
        else if (operatorInput == "/")
        {
            Console.WriteLine($"{num1} divided by {num2} is {num1 / num2}");
            Console.WriteLine("Press any key to get back to the menu....");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Not a valid operator");
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Write 'q' to exit");
            Console.WriteLine("1. Hälsa på användaren");
            Console.WriteLine("2. Multiplicera två tal");
            Console.WriteLine("3. Verifiera lösenord");
            Console.WriteLine("4. Jämför tal");
            Console.WriteLine("5. Dubblera och halvera tal");
            Console.WriteLine("6. Miniräkmare");
            string? choice = Console.ReadLine();
            string safeChoice = choice ?? "";
            switch (safeChoice)
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
                case "4":
                    Exercise4();
                    break;
                case "5":
                    Exercise5();
                    break;
                case "6":
                    Exercise6();
                    break;
                case "q":
                    Console.WriteLine("Exiting program");
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}
