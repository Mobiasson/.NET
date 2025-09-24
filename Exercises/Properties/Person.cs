#pragma warning disable CS8618

namespace Exercises.Person {
class Person {
	private string _firstName;

	public Person(string firstName) {
		_firstName = firstName;
	}

	public string FirstName {
		get{return _firstName;}
		set{_firstName = value;}
	}

	public string FullName {
		get{return _firstName + LastName;}
	}

	public string LastName {get;set;}
	}
}

namespace Exercises.StepCounter {
class StepCounter {
	public int steps;

	public int Steps {
		get{return steps;}
	}

	public void Step() {
		steps++;
		Console.WriteLine($"I have taken {steps} steps");
	}

	public void Reset() {
		steps = 0;
		Console.WriteLine("I have reseted to 0");
		}
	}
}

namespace Exercises.Car {
	class Car{
		private string model;
		private double price;
		private string color;

		public string Model { get => model; set => model = value; }
		public double Price { get => price; set => price = value; }
		public string Color { get => color; set => color = value; }

	}
}
