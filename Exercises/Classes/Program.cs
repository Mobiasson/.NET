class Program {
    static void Main(string[] args) {

        Person person1 = new Person() { firstName = "Mikael", lastName = "Ros Tobiasson" };
        Person person2 = new Person() { firstName = "Signe", lastName = "Blix Herrlander" };
        Console.WriteLine($"{person1.GetFullName()} and {person2.GetFullName()}");
		Console.WriteLine($"{person1.GetFullNameReversed()}");
    }
}
