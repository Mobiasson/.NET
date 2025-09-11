class Program
{
	static void Exercise1()
	{
		Console.WriteLine("Write sentence");
		string? input = Console.ReadLine();
		foreach (char c in input)
		{
			if (c == ' ') break;
			Console.WriteLine(c);
		}
	}

	static void Exercise2()
	{
		Console.WriteLine("Write anything you want.");
		string? input = Console.ReadLine();
		string[] split = input.Split(" ");
		foreach (string str in split) Console.WriteLine(str);
	}

	static void Exercise3()
	{
		string input = "Detta är uppgift 3";
		char[] result = input.ToCharArray();
		for (int i = 0; i < input.Length; i++) if (i % 2 == 0)
			{
				result[i] = '*';
			}
		Console.WriteLine(result);
	}

	static void Exercise4()
	{
		Console.WriteLine("Hello world!");
		string input = Console.ReadLine();
		foreach (char c in input)
		{
			if (c == 'i') Console.ForegroundColor = ConsoleColor.Red;
			else if (c == 'o') Console.ForegroundColor = ConsoleColor.Green;
			else Console.ForegroundColor = ConsoleColor.Gray;
		}
	}

	static void Exercise5()
	{
		Console.WriteLine("Hello world!");
		string input = Console.ReadLine();
		int charCount = 0;
		foreach (char c in input)
		{
			Console.WriteLine(c);
		}
	}



	static void Main(string[] args)
	{
		while (true)
		{
			Console.WriteLine("1. Bokstav för bokstav - fram till space");
			Console.WriteLine("2. Bokstav för bokstav - radbyte för space");
			Console.WriteLine("3. Bokstav för bokstav - varannan stjärna");
			Console.WriteLine("4. Bokstav för bokstav - gröna o, röda I");
			Console.WriteLine("5. Bokstav för bokstav - dubbla med grön färg");
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
				case "4":
					Exercise4();
					break;
				case "5":
					Exercise5();
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
