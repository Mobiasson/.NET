#pragma warning disable CS8618
#pragma warning disable CS1717
#pragma warning disable CS8601

namespace Exercises.Person {
	class Person {
		private string _firstName;

		public Person(string firstName) {
			_firstName = firstName;
		}

		public string FirstName {
			get { return _firstName; }
			set { _firstName = value; }
		}

		public string FullName {
			get { return _firstName + LastName; }
		}

		public string LastName { get; set; }
	}
}

namespace Exercises.StepCounter {
	class StepCounter {

		public int steps;

		public int Steps {
			get { return steps; }
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
	class Car {
		private string model;
		private double price;
		private string color;

		public string Model { get => model; set => model = value; }
		public double Price { get => price; set => price = value; }
		public string Color { get => color; set => color = value; }

		public Car() {

		}

		public Car(string model, double price, string color) {
			this.model = model;
			this.price = price;
			this.color = color;
		}

		public void HalfPrice() {
			price = price / 2;
		}


		public override string? ToString() {
			return $"The model is {model}, Price is {price} and the color is {color}";
		}
	}
}

namespace Exercises.Water {
	class Water {
		private bool isGlasFull = false;
		private bool isGlasBroken = false;

		public void FillGlas() {
			if(!isGlasFull == true) {
				isGlasFull = true;
				Console.WriteLine("I just filled the glas!");
			} else Console.WriteLine("The glas is already full!");

		}

		public void EmptyGlas() {
			if(isGlasFull == true) {
				isGlasFull = false;
				Console.WriteLine("I just emptied the glas!");
			} else Console.WriteLine("Glas is already empty!");
		}

		public void breakGlas() {
			if(isGlasBroken == false) Console.WriteLine($"The glas is broken and cannot be filled anymore"); else isGlasBroken = true;
			if(isGlasFull) {
				isGlasFull = false;
				Console.WriteLine("Glas is broken");
			} else Console.WriteLine("Glas breaking");
		}
	}
}

namespace Exercises.Colors {
	class Colors {
	static Random rnd = new Random();
	public double blue = Math.Round(rnd.NextDouble() * 100, 2);
	public double red = Math.Round(rnd.NextDouble() * 100, 2);



		}
	}


