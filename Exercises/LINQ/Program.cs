class Program {
	static void Main(string[] args) {
		// 1. Skapa en array "people"
		var people = new[] {
			new { FirstName = "Mikael", LastName = " Ros Tobiasson", Age = 33, Weight = 70, Height = 165},
			new { FirstName = "Signe", LastName = " Blix Herrlander", Age = 33, Weight = 60, Height = 165},
			new { FirstName = "Sven", LastName = " Svensson", Age = 11, Weight = 38, Height = 122},
			new { FirstName = "Amalia", LastName = " Andersson", Age = 16, Weight = 46, Height = 231},
			new { FirstName = "Greta", LastName = " Gustavsson", Age = 77, Weight = 88, Height = 130},
			new { FirstName = "Daniel", LastName = " Gry", Age = 39, Weight = 123, Height = 199},
			new { FirstName = "Olivia", LastName = " Guldbrand", Age = 22, Weight = 52, Height = 201},
			new { FirstName = "Sara", LastName = " Frö", Age = 36, Weight = 39, Height = 145},
		}.ToArray();
		// 2. Filtrera på ålder
		var agePeople = people.Where(p => p.Age < 40 && p.Age > 20).Select(p => new { p.FirstName, p.Age });
		agePeople.ToList().ForEach(age => Console.WriteLine(age));
		// 3. Är någon äldre än 190 cm
		var longerThan190 = people.Where(p => p.Age < 40 && p.Age > 20 && p.Height > 190).Select(p => new { p.FirstName, p.Age, p.Height });
		longerThan190.ToList().ForEach(p => Console.WriteLine($"Name: {p.FirstName}, Age: {p.Age}, Height: {p.Height}"));
		// 4. Filtrera på namn
		var nameLength = people.Where(p => p.FirstName.Length >= p.LastName.Length).Select(p => new { p.FirstName, p.LastName });
		nameLength.ToList().ForEach(p => Console.WriteLine($"{p.FirstName + p.LastName}"));
		// 5. Hela namnet tillsammans med BMI
		// 6. Filtrera listan ovan på BMI
		var peopleWithBMI = people.Where(p => p.Age < 20).Select(p => new {
			p.FirstName,
			p.LastName,
			p.Age,
			BMI = p.Weight / Math.Pow(p.Height / 100.0, 2)
		});
		peopleWithBMI.ToList().ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName} BMI is {p.BMI:f} and the age {p.Age}"));
		// 7. Filtrera originallistan på BMI
		var peopleBMI = people.Where(p => p.Age < 20).Select(p => new {p.FirstName, p.LastName, p.Age, BMI = p.Weight / Math.Pow(p.Height / 100, 2)}).ToList();
		peopleBMI.ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName} has a BMI of {p.BMI}"));
		// 8. Username tillsammansm med Category
		var ChildOrAdult = people.Where(p => p.Age < 18).Select(p => new {
		p.FirstName,
		p.Age,
		Category = p.Age < 18 ? "Child" : "Adult",
		userName = p.FirstName + p.Age
		}).ToList();
		ChildOrAdult.ForEach(p => Console.WriteLine($"{p.FirstName} is {p.Age} and is a {p.Category}"));
		// 9. Query syntax
		// 9.2
		var FilterWithQuery = (from p in people where p.Age < 40 && p.Age > 20 select new {p.FirstName, p.Age}).ToList();
		FilterWithQuery.ForEach(p => Console.WriteLine($"{p.FirstName} is {p.Age} years old"));
		// 9.3 Är någon längre än 190 cm
		var FilterAgeAndLength = (from p in people where p.Age < 40 && p.Age > 20 && p.Height > 190 select new {p.FirstName, p.Age, p.Height}).ToList();
		FilterAgeAndLength.ForEach(p => Console.WriteLine($"{p.FirstName} is {p.Age} years old and {p.Height} cm long."));
		// 9.4 Filtrera på namn
		var FilterNameLength = (from p in people where p.FirstName.Length >= p.LastName.Length select new {p.FirstName, p.LastName}).ToList();
		FilterNameLength.ForEach(p => Console.WriteLine($"{p.FirstName} is longer than {p.LastName}"));
		// 9.5 Hela namnet tillsammans med BMI
		var FullnameWithBMI = (from p in people select new {p.Weight, p.Height, fullname = p.FirstName + p.LastName, BMI = p.Weight / Math.Pow(p.Height / 100.0, 2)}).ToList();
		FullnameWithBMI.ForEach(p => Console.WriteLine($"{p.fullname} has a BMI of {p.BMI:f}"));
		// 9.6 Filtrera listan ovan på BMI
		var FilterByBMI = (from p in FullnameWithBMI where p.BMI < 20 || p.BMI > 25 select p).ToList();
		FilterByBMI.ForEach(p => Console.WriteLine($"{p.fullname} has a BMI of {p.BMI:f}"));
		// 9.7 Filtrera orginallistan på BMI
		var FilterArray = from p in people where p.Weight / Math.Pow(p.Height / 100.0, 2) < 20 || p.Weight / Math.Pow(p.Height / 100.0, 2) > 25 select new {p.FirstName, p.LastName, BMI = p.Weight / Math.Pow(p.Height / 100.0, 2)};
		foreach(var p in FilterArray) {
		Console.WriteLine($"{p.FirstName} has a BMI of {p.BMI:f} in original array"); }
		// 9.8 Username tillsammans med Category
		var UsernameFilter = (from p in people select new {Category = p.Age < 18 ? "Child" : "Adult", Username = p.FirstName + p.Age}).ToList();
		UsernameFilter.ForEach(p => Console.WriteLine($"{p.Username} is of {p.Category} "));
		// 10. Sortera efter längd

	}
}
