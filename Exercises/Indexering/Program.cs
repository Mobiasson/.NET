#pragma warning disable CS8602
#pragma warning disable CS8601
#pragma warning disable CS8600

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
			String? newString = input;
			for(int i = 0; i < vokaler.Length; i++) {
				newString = newString.Replace(vokaler[i], "*");
			}
			Console.WriteLine($"New replaced string: {newString}");
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
			break;
		}
	}

	static void Exercise5() {
		Console.WriteLine("Write any word.");
		string? input = Console.ReadLine();
		string? revString = input != null ? new string(input.Reverse().ToArray()) : "";
		if(input == revString) Console.WriteLine("Word is a palindrome");
		else Console.WriteLine("Word is not a palindrome");
		Console.WriteLine("Press any key to get back to menu");
		Console.ReadKey();
	}

	static void Exercise6() {
		Console.WriteLine("What do you want do calculate? (Ex. 15 * 5)");
		char[] symbols = { '+', '*', '/', '-' };
		string? input = Console.ReadLine();
		string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
	}

	static void Exercise7() {
		Console.WriteLine("Skriv in 7 ord");
		string[] strArray = new string[7];
		for(int i = 0; i < strArray.Length; i++) strArray[i] = Console.ReadLine();
		Console.WriteLine("Array is full!");
		Array.Reverse(strArray);
		Console.WriteLine(string.Join(",", strArray));
	}


	static void Exercise8() {
		List<string> wordList = new List<string>();
		Console.WriteLine("Write a random word");
		while(true) {
			string word = Console.ReadLine() ?? "";
			wordList.Add(word);
			if(wordList.Count < 10) Console.WriteLine($"Not at 10 words yet ({wordList.Count})");
			else Console.WriteLine($"10 words ago was {wordList[wordList.Count - 10]}");
		}
	}

	static void Exercise9() {
		string text = "Hello World";
		for(int i = 1; i <= text.Length; i++) {
			Console.WriteLine(text.Substring(0, i));
		}
	}

	static void Exercise10() {
		Console.WriteLine("Write anything");
		string input = Console.ReadLine();
		Console.WriteLine("Write any letter that is in your sentence");
		string letter = Console.ReadLine();
		char char1 = letter[0];
		foreach(char c in input) {
			Console.ForegroundColor = char1 == c ? ConsoleColor.Red : ConsoleColor.Gray;
			Console.Write(c);
		}
		Console.ResetColor();
		Console.WriteLine();
	}

	static void Exercise11() {
		Console.WriteLine("Write anything");
		string sentence = Console.ReadLine();
		Console.WriteLine("Write a starting index");
		if(!int.TryParse(Console.ReadLine(), out int startIndex)) Console.WriteLine("This is not an integer");
		Console.WriteLine("Write a stop index");
		if(!int.TryParse(Console.ReadLine(), out int stopIndex)) Console.WriteLine("Not an integer");
		for (int i = 0; i < sentence.Length; i++) {
			Console.ForegroundColor = (i >= startIndex && i <= stopIndex) ? ConsoleColor.Red : ConsoleColor.White;
			Console.Write(sentence[i]);
		}
		Console.ResetColor();
		Console.WriteLine();
	}

	static void Main(string[] args) {
		while(true) {
			Console.WriteLine("1. En bokstav på varje rad");
			Console.WriteLine("2. Siffror till text");
			Console.WriteLine("3. Baklänges");
			Console.WriteLine("4. Dölj vokaler");
			Console.WriteLine("5. Palindrom");
			Console.WriteLine("6. Miniräknare");
			Console.WriteLine("7. Omvänd ordning");
			Console.WriteLine("8. Fördröjd utskrift");
			Console.WriteLine("9. Bokstavspyramid");
			Console.WriteLine("10. Färgade bokstäver");
			Console.WriteLine("11. Start & Stop");
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
				case "5":
					Exercise5();
					break;
				case "6":
					Exercise6();
					break;
				case "7":
					Exercise7();
					break;
				case "8":
					Exercise8();
					break;
				case "9":
					Exercise9();
					break;
				case "10":
					Exercise10();
					break;
				case "11":
					Exercise11();
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
