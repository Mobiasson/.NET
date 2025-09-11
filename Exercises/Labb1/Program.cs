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
			for(int i = 0;i < input.Length; i++) if(i % 2 == 0) {
				result[i] = '*';
		}
			Console.WriteLine(result);
	}




	static void Main(string[] args) {
		while(true) {
			Console.WriteLine("1. Bokstav för bokstav - fram till space");
			Console.WriteLine("2. Bokstav för bokstav - radbyte för space");
			Console.WriteLine("3. Bokstav för bokstav - varannan stjärna");
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
