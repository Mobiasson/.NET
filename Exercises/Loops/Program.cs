class Loops {
	/* 1. Skriv talen 20 till 30 */
	static void Exercise1() {
		for(int i = 20; i <= 30; i++) {
			Console.WriteLine(i);
		}
	}

	/* 2. Jämna tal */
	static void Exercise2() {
		for(int i = 0; i <= 30; i += 2) {
			Console.WriteLine(i);
		}
	}

	// 3. Var tredje "Hej"
	static void Exercise3() {
		for(int i = 0; i <= 30; i++) {
			if(i % 3 == 0) {
				Console.WriteLine("Hej");
			} else {
				Console.WriteLine(i);
			}
		}
	}

	/* 4. Gångertabell */
	static void Exercise4() {
		Console.WriteLine("Write a number 1-9 for multiplication-table");
		string? input = Console.ReadLine();
		while(!int.TryParse(input, out int value)) {
			Console.WriteLine("Not a number");
			input = Console.ReadLine();
		}
		int.TryParse(input, out int value2);
		for(int i = 1; i <= 10; i++) {
			Console.WriteLine($"{value2} * {i} = {value2 * i}");
		}
	}

	/* 5. Summa */
	static void Exercise5() {
		int sum = 0;
		for(int i = 0; i <= 1000; i++) {
			sum += i;
		}
		Console.WriteLine($"Sum of 1 to 1000 is {sum}");
	}

	/* 6. Riskorn på schackbräde */
	static void Exercise6() {
		double rice = 1;
		for(int i = 1; i <= 64; i++) {
			for(int j = 1; j <= 5; j++) {
				rice = Math.Pow(2, i - 1);
			}
			Console.WriteLine($"Square {i}: {rice}");
		}
	}

	/* 7. Fylld box */
	static void Exercise7() {
		Console.WriteLine("Enter a height");
		string? heightInput = Console.ReadLine();
		Console.WriteLine("Enter a width");
		string? widthInput = Console.ReadLine();
		int.TryParse(heightInput, out int heightValue);
		int.TryParse(widthInput, out int widthValue);
		for(int i = 1; i <= heightValue; i++) {
			for(int j = 2; j <= widthValue; j++) {
				Console.Write("X");
			}
			Console.WriteLine("X");
		}
	}

	/* 8. Randig box */
	static void Exercise8() {
		Console.WriteLine("Enter a height");
		string? heightInput = Console.ReadLine();
		Console.WriteLine("Enter a width");
		string? widthInput = Console.ReadLine();
		int.TryParse(heightInput, out int heightValue);
		int.TryParse(widthInput, out int widthValue);
		for(int i = 1; i <= heightValue; i++) {
			for(int j = 2; j <= widthValue; j++) {
				if(j % 2 == 0) {
					Console.Write("X");
				} else {
					Console.Write("O");
				}
			}
			Console.WriteLine("X");
		}
	}
	/* 9. Rutig box */
	static void Exercise9() {
		Console.WriteLine("Enter a height");
		string? heightInput = Console.ReadLine();
		Console.WriteLine("Enter a width");
		string? widthInput = Console.ReadLine();
		int.TryParse(heightInput, out int heightValue);
		int.TryParse(widthInput, out int widthValue);
		for(int i = 1; i <= heightValue; i++) {
			for(int j = 1; j <= widthValue; j++) {
				if(i % 2 == 1) {
					Console.Write(j % 2 == 1 ? "X" : "O");
				} else {
					Console.Write(j % 2 == 1 ? "O" : "X");
				}
			}
			Console.WriteLine();
		}
	}

	static void Main(string[] args) {
		while(true) {
			Console.WriteLine("Write 'q' to exit");
			Console.WriteLine("1. Skriv tal 20 till 30");
			Console.WriteLine("2. Jämna tal");
			Console.WriteLine("3. Var tredje 'Hej'");
			Console.WriteLine("4. Gångertabell");
			Console.WriteLine("5. Summa");
			Console.WriteLine("6. Riskorn på schackbräde");
			Console.WriteLine("7. Fylld box");
			Console.WriteLine("8. Randig box");
			Console.WriteLine("9. Rutig box");
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
