class Program {
	static void Exercise1(string firstName, string lastName) {
		Console.WriteLine($"{firstName + lastName}");
	}

	static string Exercise2(string firstName, string lastName) {
		string name = firstName + lastName;
		Console.WriteLine(name);
		return name;
	}

	static bool Exercise3(string input, int strLength) {
		if(input.Length > strLength) return true;
		else return false;
	}

	static double Exercise4(double celsius) {
		double fahrenheit = ((celsius * 9 / 5) + 32);
		return fahrenheit;
	}


	static void Main(string[] args) {
		while(true) {
			Console.WriteLine("1. Slå ihop för- och efternamn - skriv ut");
			Console.WriteLine("2. Slå ihop för- och efternamn - returnera");
			Console.WriteLine("3. Kolla om strängen är längre än ett givet antal tecken");
			Console.WriteLine("4. Omvandla Celsius till Fagrenheit");
			string? choice = Console.ReadLine();
			switch(choice) {
				case "0":
					break;
				case "1":
					Exercise1("Mikael ", "Ros Tobiasson");
					break;
				case "2":
					Exercise2("Mikael ", "Ros Tobiasson");
					break;
				case "3":
					Console.WriteLine(Exercise3("hello world", 5));
					break;
				case "4":
					Console.WriteLine(Exercise4(30));
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
