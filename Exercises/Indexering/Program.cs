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
		Console.WriteLine("Write a number 0-9");
		string? input = Console.ReadLine();
		int value = StringToInt(input);
		Console.WriteLine(stringsArray[value]);
	}



	static void Main(string[] args) {
		while(true) {
			Console.WriteLine("1. En bokstav på varje rad");
			Console.WriteLine("2. Siffror till text");
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
}
