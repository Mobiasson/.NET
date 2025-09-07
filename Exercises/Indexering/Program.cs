#pragma warning disable CS8602
class Indexing {
	static void Exercise1() {
		Console.WriteLine("Write any word");
		string? input = Console.ReadLine();
		foreach(char c in input) {
			Console.WriteLine(c);
		}
	}
	static void Exercise2() {
		string[] stringsArray = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
		Console.WriteLine("Write a number 0-9:");
		while(true) {
			try {
				string? input = Console.ReadLine();
				if(!int.TryParse(input, out int value)) Console.WriteLine("This is not an integer! Try again! 0-9");
				else Console.WriteLine(stringsArray[value]);
			} catch(IndexOutOfRangeException) {
				Console.WriteLine("Not in the range of 0-9. Try again!");
			}
		}
	}


	static void Exercise3() {
		Console.WriteLine("Write anything you want.");
		string? input = Console.ReadLine();
		for(int i = input.Length - 1; i >= 0; i--) {
			Console.WriteLine(input[i]);
		}
	}

	static void Exercise4() {
		Console.WriteLine("Write anything you want.");
		while(true) {
			string? input = Console.ReadLine();
			NullStringChecker(input);
			string[] vokaler = { "a", "e", "i", "o", "u", "y", "å", "ä", "ö" };
			String newString = input;
			for(int i = 0; i < vokaler.Length; i++) {
				newString = newString.Replace(vokaler[i], "*");
			}
			Console.WriteLine($"New replaced string: {newString}");
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
			break;
		}
	}

	static void Main(string[] args) {
		while(true) {
			Console.WriteLine("1. En bokstav på varje rad");
			Console.WriteLine("2. Siffror till text");
			Console.WriteLine("3. Baklänges");
			Console.WriteLine("4. Dölj vokaler");
			string? choice = Console.ReadLine();
			switch(choice) {
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
				case "q":
					Console.WriteLine("Exiting program");
					return;
				default:
					Console.WriteLine("Invalid choice, try again!");
					break;

			}
		}
	}

	static bool IsInt(string input) {
		return int.TryParse(input, out _);
	}

	static int StringToInt(string input) {
		if(int.TryParse(input, out int value)) {
			return value;
		}
		return -1;
	}

	static bool NullStringChecker(string? input) {
		if(string.IsNullOrEmpty(input)) {
			Console.WriteLine("String is null or empty. Try again!");
			return false;
		}
		if(input.All(char.IsDigit)) {
			Console.WriteLine("Cannot be a digit. Try again!");
			return false;
		}
		return true;
	}
}
