class Program {
	static void Main(string[] args) {



		Vehicle myVehicle = new Vehicle(Brand.Toyota, Color.White);
		Console.WriteLine(new Car(Brand.Toyota, Color.White, "Yaris"));

		var circle = new Circle(5);
		Console.WriteLine(circle);
		Console.WriteLine($"Area: {circle.Area:f2}");
		Console.WriteLine($"Circumference: {circle.Circumference:f2}");
	}
}
