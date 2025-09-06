class Indexing {



	static void Main(string[] args) {
		while(true) {
			Console.WriteLine("1. En bokstav på varje rad");
			string? choice = Console.ReadLine();
			switch(choice) {
				case "0":
					break;
				case "1":
					Exercise1();
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
