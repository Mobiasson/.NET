class Labb {
	static void Main(string[] args) {
		string randomString = randomStringGen(50);
		ulong sum = 0;
		for(int i = 0; i < randomString.Length; i++) {
			int nextIndex = randomString.IndexOf(randomString[i], i + 1);
			if(nextIndex != -1 && letterChecker(randomString, i, nextIndex)) {
				string digitString = string.Concat(randomString.Substring(i, nextIndex - i + 1).Where(char.IsDigit)); sum += ulong.Parse(digitString);
				for(int j = 0; j < randomString.Length; j++) {
					Console.ForegroundColor = (j >= i && j <= nextIndex) ? ConsoleColor.Red : ConsoleColor.Gray; Console.Write(randomString[j]);
				}
				Console.WriteLine();
			}
			Console.ResetColor();
		}
		Console.WriteLine($"The sum of everything is {sum}");
	}

	static string randomStringGen(int stringLength) {
		Random rdn = new Random();
		char[] charArr = new char[stringLength];
		string digits = "0123456789";
		string letters = "abcdefghijklmnopqrstuvwxyz";
		string symbols = "' '!#¤%&/()=?^*";
		for(int i = 0; i < charArr.Length; i++) if(rdn.NextDouble() < 0.8) charArr[i] = digits[rdn.Next(digits.Length)];
		else if(rdn.NextDouble() < 0.1) charArr[i] = symbols[rdn.Next(symbols.Length)];
			else charArr[i] = letters[rdn.Next(letters.Length)];
		string longString = new String(charArr);
		return longString;
	}


	static bool letterChecker(string input, int startIndex, int endIndex) {
		for(int i = startIndex; i <= endIndex; i++) {
			if(!char.IsDigit(input[i])) return false;
		}
		return true;
	}
}
