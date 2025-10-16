class Program {
	static void Main(string[] args) {
		// Skapa en array "people"
		var people = new[] {
			new { FirstName = "Mikael", LastName = " Ros Tobiasson", Age = 33, Weight = 70, Height = 1.65},
			new { FirstName = "Signe", LastName = " Blix Herrlander", Age = 33, Weight = 60, Height = 1.65},
			new { FirstName = "Sven", LastName = " Svensson", Age = 11, Weight = 38, Height = 1.22},
			new { FirstName = "Amalia", LastName = " Andersson", Age = 16, Weight = 46, Height = 1.60},
			new { FirstName = "Greta", LastName = " Gustavsson", Age = 77, Weight = 88, Height = 1.30},
			new { FirstName = "Daniel", LastName = " Danielsson", Age = 55, Weight = 123, Height = 1.92},
			new { FirstName = "Olivia", LastName = " Guldbrand", Age = 22, Weight = 52, Height = 1.78},
			new { FirstName = "Sara", LastName = " Holgersson", Age = 36, Weight = 39, Height = 1.45},
		}.ToList();
		// Filtrera på ålder
		var agePeople = people.Where(p => p.Age < 40 && p.Age > 20).Select(p => new { p.FirstName, p.Age });
		agePeople.ToList().ForEach(age => Console.WriteLine(age));


	}
}
