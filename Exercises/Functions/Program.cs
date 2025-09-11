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


	static string Exercise5(string input) {
		string newString = string.Join("-", input);
		return newString;
	}

 	static string Exercise6(string sign, params string[] arrayOfStrings) {
		string wordArray = arrayOfStrings[0];
		for(int i = 1; i < arrayOfStrings.Length; i++) wordArray += sign + arrayOfStrings[i];
		return wordArray;
	}

	static double Exercise7(params int[] intArray) {
		double average;
		int sum = 0;
		for(int i = 0;i < intArray.Length; i++) {
			sum += intArray[i];
		}
		average = sum / intArray.Length;
		return average;
	}

	static string[] Exercise8(int number) {
		string[] numbArray = {"noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio"};


	}

	static void TestProg() {
		int i = 15123;
		char c = Convert.ToChar(i);

	}


	static void Main(string[] args) {
		while(true) {
			Console.WriteLine("1. Slå ihop för- och efternamn - skriv ut");
			Console.WriteLine("2. Slå ihop för- och efternamn - returnera");
			Console.WriteLine("3. Kolla om strängen är längre än ett givet antal tecken");
			Console.WriteLine("4. Omvandla Celsius till Fagrenheit");
			Console.WriteLine("5. Lägg in bindesträck mellan tecken i en sträng");
			Console.WriteLine("6. Egen version av String.Join()");
			Console.WriteLine("7. Beräkna medelvärde av int-array");
			Console.WriteLine("8. Siffror till text");
			Console.WriteLine("9. Testing");
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
				case "5":
					Console.WriteLine(Exercise5("Mikael"));
					break;
				case "6":
					Console.WriteLine(Exercise6("->","Sverige", "Norge", "Finland"));
					break;
				case "7":
					Console.WriteLine(Exercise7(5,8,9,5,2,5));
					break;
				case "8":
					Console.WriteLine(Exercise8(12345));
					break;
				case "9":
					TestProg();
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
