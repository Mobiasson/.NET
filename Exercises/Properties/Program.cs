#pragma warning disable CS8618

using Exercises.Person;
using Exercises.StepCounter;

class Program {
	static void Main(string[]args) {

	Person person1 = new Person("Mikael");
	person1.LastName = "Ros Tobiasson";
	/* Console.WriteLine($"{person1.FirstName} {person1.LastName}"); */
	Console.WriteLine($"{person1.FullName}");

	StepCounter sc = new StepCounter();
	for(int i = 0; i < 1000; i++) {
			sc.Step();
	}
	sc.Reset();

	}
}


