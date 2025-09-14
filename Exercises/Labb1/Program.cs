#pragma warning disable CS8602
#pragma warning disable CS8600

class Program {
	static void Exercise1() {
		Console.WriteLine("Write sentence");
		string? input = Console.ReadLine();
		foreach(char c in input) {
			if(c == ' ') break;
			Console.WriteLine(c);
		}
	}

	static void Exercise2() {
		Console.WriteLine("Write anything you want.");
		string? input = Console.ReadLine();
		string[] split = input.Split(" ");
		foreach(string str in split) Console.WriteLine(str);
	}

	static void Exercise3() {
		string input = "Detta är uppgift 3";
		char[] result = input.ToCharArray();
		for(int i = 0; i < input.Length; i++) if(i % 2 == 0) {
				result[i] = '*';
			}
		Console.WriteLine(result);
	}

	static void Exercise4() {
		string input = "Hello World";
		foreach(char c in input) {
			if(c == 'l') Console.ForegroundColor = ConsoleColor.Red;
			else if(c == 'o') Console.ForegroundColor = ConsoleColor.Green;
			else Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write(c);
		}
		Console.ResetColor();
		Console.WriteLine();
	}

	static void Exercise5() {
		string input = "Hello world!";
		for(int i = 0; i < input.Length; i++) {
			if(i < input.Length - 1 && input[i] == input[i + 1]) {
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write(input[i]);
				Console.Write(input[i + 1]);
				i++;
			} else {
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write(input[i]);
			}
		}
		Console.ResetColor();
		Console.WriteLine();
	}

	static void Exercise6() {
		string input = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
		string shortInput = "oo";
			for(int i = 0; i < input.Length;i++) {
					if(i < input.Length - 1 && input.Substring(i, 2) == shortInput){
							Console.ForegroundColor = ConsoleColor.Green;
							Console.Write(input[i]);
							Console.Write(input[i + 1]);
					} else {
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write(input[i]);
					}
				}
				Console.ResetColor();
				Console.WriteLine();
			}

	static void Exercise7() {

	}


	static void Main(string[] args) {
		while(true) {
			Console.WriteLine();
			Console.WriteLine("1. Bokstav för bokstav - fram till space");
			Console.WriteLine("2. Bokstav för bokstav - radbyte för space");
			Console.WriteLine("3. Bokstav för bokstav - varannan stjärna");
			Console.WriteLine("4. Bokstav för bokstav - gröna o, röda I");
			Console.WriteLine("5. Bokstav för bokstav - dubbla med grön färg");
			Console.WriteLine("6. Bokstav för bokstav - grön substring");
			Console.WriteLine("7. Bokstav för bokstav - grön substring 2");
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
