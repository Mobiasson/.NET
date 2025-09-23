#pragma warning disable CS8602
#pragma warning disable CS0219

class Program {
	static void Main(string[] args) {
		try {
			StreamReader sr = new("input.txt");
			List<String> leftList = new List<String>();
			List<String> rightList = new List<String>();
			int difference = 0;
			while(!sr.EndOfStream) {
				string[] numbers = sr.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
				if(numbers.Length == 2) {
					leftList.Add(numbers[0]);
					rightList.Add(numbers[1]);
				}
				leftList.Sort();
				rightList.Sort();
			}

			Console.WriteLine("left list: " + string.Join(' ', leftList));
			Console.WriteLine("right list: " + string.Join(' ', rightList));



		} catch(FileNotFoundException ex) {
			Console.WriteLine(ex.Message);
		}
	}
}
