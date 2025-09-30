#pragma warning disable CS8618
#pragma warning disable CS8019

using Exercises.Person;
using Exercises.StepCounter;
using Exercises.Car;
using Exercises.Water;
using Exercises.Colors;
using Exercises.Temperature;
using Exercises.Car2;

class Program {
	static void Main(string[] args) {

		/* Person person1 = new Person("Mikael");
		person1.LastName = "Ros Tobiasson";
		Console.WriteLine($"{person1.FirstName} {person1.LastName}");
		Console.WriteLine($"{person1.FullName}");

		StepCounter sc = new StepCounter();
		for(int i = 0; i < 1000; i++) {
			sc.Step();
		}

		Car car = new Car("BMW", 1500000, "Black");
		car.HalfPrice();
		Console.WriteLine(car);

		Water waterGlas = new Water();
		waterGlas.FillGlas();
		waterGlas.FillGlas();
		waterGlas.EmptyGlas();
		waterGlas.EmptyGlas();
		waterGlas.breakGlas();
		waterGlas.FillGlas(); */


		// Colors colors = new Colors();
		// colors.blue = 100 - colors.red;
		// Console.WriteLine($"Color blue is: {colors.blue}");


		// Temperature t = new() { Farenheit = 40 };

		// Console.WriteLine($"Kelvin:   {t.Kelvin,10:f2}");
		// Console.WriteLine($"Celcius:  {t.Celcius,10:f2}");
		// Console.WriteLine($"Farenheit:{t.Farenheit,10:f2}");

		Car2 myNewCar = new Car2(Car2.RandomColor(), 5);
		Car2[] myCars = new Car2[1000];
		for(int i = 0;i < myCars.Length;i++) myCars[i] = new Car2(Car2.RandomColor(), 5);
		double result = Car2.SumOfCarLength(myCars);
		Console.WriteLine($"The sumLength of all the cars that are green are {result:f2}");

	}
}


