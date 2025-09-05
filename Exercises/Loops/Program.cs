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
				Console.Write(j % 2 == 0 ? "X" : "O");
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
	/* 10. Ihålig box */
	static void Exercise10() {
		Console.WriteLine("Enter a height");
		string? heightInput = Console.ReadLine();
		Console.WriteLine("Enter a width");
		string? widthInput = Console.ReadLine();
		int.TryParse(heightInput, out int heightValue);
		int.TryParse(widthInput, out int widthValue);
		for(int i = 1; i <= heightValue; i++) {
			for(int j = 2; j <= widthValue; j++) {
				Console.Write("X"); /* Bredd */
			}
			Console.WriteLine("X"); /* Höjd*/
		}
	}
	/*11. Sifferpyramid*/
	static void Exercise11() {
		for(int i = 1; i <= 9; i++) {
			for(int j = 1; j <= i; j++) {
				Console.Write(j);
			}
			Console.WriteLine();
		}
	}
	/*12. Nio sifferpyramider*/
	static void Exercise12() {
		for(int i = 1; i <= 9; i++) {
			for(int j = 1; j <= i; j++) {
				for(int y = 1; y <= j; y++) {
					Console.Write(y);
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
	/*13. Primtal*/
	static void Exercise13() {
		List<int> primalList = new List<int>();
		for(int i = 2; i <= 100; i++) {
			int divideCounter = 0;
			for(int j = 1; j <= i; j++) if(i % j == 0) divideCounter++;
			if(divideCounter == 2) {
				Console.WriteLine($"{i} is prime");
				primalList.Add(i);
			} else Console.WriteLine($"{i} is not prime");
			if(primalList.Count == 20) break;
		}
		Console.WriteLine($"That's 20 primnumbers {string.Join(" ", primalList)}");
	}

	/*14. Spel - Gissa tl*/
	static void Exercise14() {
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
			Console.WriteLine("10. Ihålig box");
			Console.WriteLine("11. Sifferpyramid");
			Console.WriteLine("12. Nio sifferpyramider");
			Console.WriteLine("13. Primtal");
			Console.WriteLine("14. Spel - Gissa tal");
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
				case "12":
					Exercise12();
					break;
				case "13":
					Exercise13();
					break;
				case "14":
					Exercise14();
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
