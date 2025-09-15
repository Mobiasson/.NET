class Loops {
	static void Exercise1() {
		for(int i = 20; i <= 30; i++) Console.WriteLine(i);
	}

	static void Exercise2() {
		for(int i = 0; i <= 30; i += 2) Console.WriteLine(i);
	}

	static void Exercise3() {
		for(int i = 0; i <= 30; i++) {
			if(i % 3 == 0) Console.WriteLine("Hej");
			else Console.WriteLine(i);
		}
	}

	static void Exercise4() {
		Console.WriteLine("Write a number 1-9 for multiplication-table");
		string? input = Console.ReadLine();
		while(!int.TryParse(input, out int value)) {
			Console.WriteLine("Not a number");
			input = Console.ReadLine();
		}
		int.TryParse(input, out int value2);
		for(int i = 1; i <= 10; i++) Console.WriteLine($"{value2} * {i} = {value2 * i}");
	}

	static void Exercise5() {
		int sum = 0;
		for(int i = 0; i <= 1000; i++) sum += i;
		Console.WriteLine($"Sum of 1 to 1000 is {sum}");
	}

	static void Exercise6() {
		double rice = 1;
		for(int i = 1; i <= 64; i++) {
			for(int j = 1; j <= 5; j++) rice = Math.Pow(2, i - 1);
			Console.WriteLine($"Square {i}: {rice}");
		}
	}

	static void Exercise7() {
		Console.WriteLine("Enter a height");
		string? heightInput = Console.ReadLine();
		Console.WriteLine("Enter a width");
		string? widthInput = Console.ReadLine();
		int.TryParse(heightInput, out int heightValue);
		int.TryParse(widthInput, out int widthValue);
		for(int i = 1; i <= heightValue; i++) {
			for(int j = 2; j <= widthValue; j++) Console.Write("X");
			Console.WriteLine("X");
		}
	}

	static void Exercise8() {
		Console.WriteLine("Enter a height");
		string? heightInput = Console.ReadLine();
		Console.WriteLine("Enter a width");
		string? widthInput = Console.ReadLine();
		int.TryParse(heightInput, out int heightValue);
		int.TryParse(widthInput, out int widthValue);
		for(int i = 1; i <= heightValue; i++) {
			for(int j = 2; j <= widthValue; j++) Console.Write(j % 2 == 0 ? "X" : "O");

			Console.WriteLine("X");
		}

	}
	static void Exercise9() {
		Console.WriteLine("Enter a height");
		string? heightInput = Console.ReadLine();
		Console.WriteLine("Enter a width");
		string? widthInput = Console.ReadLine();
		int.TryParse(heightInput, out int heightValue);
		int.TryParse(widthInput, out int widthValue);
		for(int i = 1; i <= heightValue; i++) {
			for(int j = 1; j <= widthValue; j++) {
				if(i % 2 == 1) Console.Write(j % 2 == 1 ? "X" : "O");
				else Console.Write(j % 2 == 1 ? "O" : "X");
			}
			Console.WriteLine();
		}
	}

	static void Exercise10() {
		Console.WriteLine("Enter a height");
		string? heightInput = Console.ReadLine();
		Console.WriteLine("Enter a width");
		string? widthInput = Console.ReadLine();
		int.TryParse(heightInput, out int heightValue);
		int.TryParse(widthInput, out int widthValue);
		for(int i = 1; i <= heightValue; i++) {
			for(int j = 2; j <= widthValue; j++) Console.Write("X");
			Console.WriteLine("X");
		}
	}

	static void Exercise11() {
		for(int i = 1; i <= 9; i++) {
			for(int j = 1; j <= i; j++) Console.Write(j);
			Console.WriteLine();
		}
	}

	static void Exercise12() {
		for(int i = 1; i <= 9; i++) {
			for(int j = 1; j <= i; j++) {
				for(int y = 1; y <= j; y++) Console.Write(y);
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}


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

	static void Exercise14() {
		Random rd = new Random();
		int randomNum = rd.Next(100);
		Console.WriteLine("Guess what the secret number is :)");
		while(true) {
			if(!int.TryParse(Console.ReadLine(), out int guess)) {
				Console.WriteLine("Can't be negative! Try again!");
			}
			if(guess != randomNum) {
				string hint = guess == randomNum ? "Correct! You guessed the number!" :
										  guess > randomNum + 10 ? "Your guess is too high!" :
										  guess > randomNum + 5 ? "Still too high, but closer!" :
										  guess < randomNum - 10 ? "Your guess is too low!" :
										  guess < randomNum - 5 ? "Still too low, bug closer!" :
										  "Now you're really close!";
				Console.WriteLine(hint);
			} else {
				Console.WriteLine("Correct!");
				Console.WriteLine("Press any key to get back to the menu...");
				Console.ReadKey();
				break;
			}
		}
	}

	static void Exercise14ai() {
		Random rd = new Random();
		int randomNum = rd.Next(100);
		int nextGuess = rd.Next(100);
		Console.WriteLine($"Computer guessed {nextGuess}");
		while(nextGuess != randomNum) {
			if(nextGuess > randomNum + 10) {
				nextGuess -= 10;
				Console.WriteLine($"Guess is 10 or more too high {nextGuess}");
			} else if(nextGuess > randomNum + 5) {
				nextGuess -= 5;
				Console.WriteLine($"Guess is 5 or more too high {nextGuess}");
			} else if(nextGuess < randomNum - 10) {
				nextGuess += 10;
				Console.WriteLine($"Guess is 10 or more too low {nextGuess}");
			} else if(nextGuess < randomNum - 5) {
				nextGuess += 5;
				Console.WriteLine($"Guess is 5 or more too low {nextGuess}");
			} else {
				nextGuess = rd.Next(randomNum - 5, randomNum + 6);
				Console.WriteLine($"Next guess: {nextGuess}");
			}
		}
		Console.WriteLine($"Correct! The number was {randomNum}");
	}

	static void Exercise15() {
		Random rd = new Random();
		int playerScore = 0;
		int compScore = 0;
		string[] choices = { "rock", "scissors", "paper" };
		while(true) {
			Console.WriteLine("Choose your weapon! rock, paper or scissors");
			string? choice = Console.ReadLine().ToLower();
			string compChoice = choices[rd.Next(choices.Length)];
			Console.WriteLine($"Player chose {choice}. Computer chose {compChoice}");
			string result = choice == "rock" && compChoice == "scissors" ? "You win!" :
					choice == "rock" && compChoice == "rock" ? "Let's go again!" :
					choice == "rock" && compChoice == "paper" ? "You lose!" :
					choice == "scissors" && compChoice == "paper" ? "You win!" :
					choice == "scissors" && compChoice == "scissors" ? "Let's go again!" :
					choice == "scissors" && compChoice == "rock" ? "You lose!" :
					choice == "paper" && compChoice == "rock" ? "You win!" :
					choice == "paper" && compChoice == "paper" ? "Let's go again!" :
					choice == "paper" && compChoice == "scissors" ? "You lose" : "";
					if(result == "You win!") playerScore ++;
					else if(result == "You lose!") compScore++;
			Console.WriteLine(result);
			Console.WriteLine($"The score is: {playerScore} to the player. And {compScore} to the computer");
			Console.ReadKey();
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
			Console.WriteLine("10. Ihålig box");
			Console.WriteLine("11. Sifferpyramid");
			Console.WriteLine("12. Nio sifferpyramider");
			Console.WriteLine("13. Primtal");
			Console.WriteLine("14. Spel - Gissa tal");
			Console.WriteLine("15. Sten,sax, påse");
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
					Console.WriteLine("Do you want to play yourself? Y/N");
					Console.WriteLine("If you want the computer to play, write 'comp'");
					string? option = Console.ReadLine().ToLower();
					switch(option) {
						case "y":
							Exercise14();
							break;
						case "n":
							break;
						case "comp":
							Exercise14ai();
							break;
					}
					break;
				case "15":
					Exercise15();
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
