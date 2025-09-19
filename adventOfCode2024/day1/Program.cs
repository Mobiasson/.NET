#pragma warning disable CS8602

class Program {
	static void Main(string[] args) {
		try {
			StreamReader sr = new("input.txt");
			List<string> leftList = new List<string>();
			List<string> rightList = new List<string>();
			while(!sr.EndOfStream) {





			}
}





		catch(FileNotFoundException ex) {
			Console.WriteLine(ex.Message);
		}
	}
}
