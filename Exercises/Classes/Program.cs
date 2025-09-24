class Program {
    static void Main(string[] args) {


        Person person1 = new Person() { firstName = "Mikael", lastName = "Ros Tobiasson"};
        Person person2 = new Person() { firstName = "Signe", lastName = "Blix Herrlander" };


		Person mother = new Person {
			firstName = "Ulla",
			lastName = "Ros Tobiasson"
		};

		Person father = new Person {
			firstName = "Göran",
			lastName = "Tobiasson"
		};

		person1.mother = mother;
		person1.father = father;

        Console.WriteLine($"{person1.GetFullName()} and {person2.GetFullName()}");
		Console.WriteLine($"{person1.GetFullName("Mr")}");
		Console.WriteLine($"{person1.GetFullName()} {person1.mother.GetFullName()}");
		Console.WriteLine($"{person1.GetSelfAndParents()}");
    }
}
