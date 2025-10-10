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
		for(int i = 0; i < intArray.Length; i++) {
			sum += intArray[i];
		}
		average = sum / intArray.Length;
		return average;
	}

	static string[] Exercise8(int number) {
		string[] digitWords = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
		string numStr = number.ToString();
		string[] result = new string[numStr.Length];
		for(int i = 0; i < numStr.Length; i++) {
			int digit = int.Parse(numStr[i].ToString());
			result[i] = digitWords[digit];
		}
		return result;
	}

	static string Exercise9(ushort input) {
		string numbToString = input.ToString();
		for(int i = 0; i < numbToString.Length; i++) {
			Console.Write(numbToString[i]);
		}
		return numbToString;
	}

	static int[] Exercise10(string text, char c) {
		int[] stringArray = [text.Length];
		for(int i = 0; i < text.Length; i++) {
			if(text.ToLower().Contains(c)) {
				stringArray[i] = i;
			}
		}
		return stringArray;
	}

	static void Exercise11() {
		Random rnd = new Random();
		int diceThrow = rnd.Next(1, 6);
		Console.WriteLine(diceThrow);
	}

	static void Exercise12(int width, int height) {
		for(int i = 0; i < height; i++) {
			for(int j = 0; j < width; j++) {
				if(i == 0 || i == height - 1 || j == 0 || j == width - 1) Console.Write("#");
				else Console.Write("-");
			}
			Console.WriteLine();
		}
	}

	static void Exercise13(int width, int height) {
		int x = width / 2;
		int y = height / 2;
		while(true) {
			if(Console.KeyAvailable) {
				ConsoleKeyInfo key = Console.ReadKey(true);
				if(key.Key == ConsoleKey.UpArrow && y > 1) y--;
				if(key.Key == ConsoleKey.DownArrow && y < height - 2) y++;
				if(key.Key == ConsoleKey.LeftArrow && x > 1) x--;
				if(key.Key == ConsoleKey.RightArrow && x < width - 2) x++;
			}
			Console.Clear();
			for(int i = 0; i < height; i++) {
				for(int j = 0; j < width; j++) {
					if(i == y && x == j) Console.Write("@");
					else if(i == 0 || i == height - 1 || j == 0 || j == width - 1) Console.Write("#");
					else Console.Write("-");
				}
				Console.WriteLine();
			}
			System.Threading.Thread.Sleep(100);
		}
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
			Console.WriteLine("9. Heltal till text");
			Console.WriteLine("10. Hitta index för alla förekomster av ett givet tecken");
			Console.WriteLine("11. Kasta tärning");
			Console.WriteLine("12. Rita en box");
			Console.WriteLine("13. Flytta runt med piltangenterna");
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
					Console.WriteLine(Exercise6("->", "Sverige", "Norge", "Finland"));
					break;
				case "7":
					Console.WriteLine(Exercise7(5, 8, 9, 5, 2, 5));
					break;
				case "8":
					Console.WriteLine(string.Join(", ", Exercise8(12345)));
					break;
				case "9":
					Exercise9(12345);
					break;
				case "10":
					Exercise10("Hello world!", 'o');
					break;
				case "11":
					Exercise11();
					break;
				case "12":
					Exercise12(12, 8);
					break;
				case "13":
					Exercise13(12, 8);
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
