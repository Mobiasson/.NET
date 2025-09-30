#pragma warning disable CS8618
#pragma warning disable CS1717
#pragma warning disable CS8601
#pragma warning disable CS8605

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

namespace Exercises.Temperature {
	class Temperature {
		private double _celcius;

		public double Celcius { get => _celcius; set { if(value < 0) throw new ArgumentOutOfRangeException("COLD!"); _celcius = value; } }
		public double Kelvin {
			get => _celcius + 273.15; set {
				if(value < 0) throw new ArgumentOutOfRangeException("ITS VERY COLD!");
				_celcius = (value - 273.15);
			}
		}
		public double Farenheit {
			get => _celcius * 9 / 5 + 32;
			set {
				if(value < 0) throw new ArgumentOutOfRangeException("VERY COLD!");
				_celcius = (value - 32) * 5.0 / 9.0;
			}
		}


	}
}

namespace Exercises.Car2 {
	class Car2 {
		public static Random rnd = new Random();
		private ConsoleColor color;
		private double length;

		public ConsoleColor Color { get => color; set => color = value; }
		public double Length { get => length; set => length = rnd.NextDouble() * 5.0; }

		public Car2(ConsoleColor color, double length) {
			this.Color = color;
			this.Length = length;
		}

		public static double SumOfCarLength(params object[] cars) {
		double sumOfLength = 0;
		foreach(Car2 car in cars) {
		if(car.Color == ConsoleColor.Green) sumOfLength += car.Length;
		}
			return sumOfLength;
		}

		public static ConsoleColor RandomColor() {
			Array values = Enum.GetValues(typeof(ConsoleColor));
			return (ConsoleColor)values.GetValue(rnd.Next(values.Length));
		}
	}
}



