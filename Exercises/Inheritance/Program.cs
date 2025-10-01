class Program {
	static void Main(string[] args) {
		Vehicle myVehicle = new Vehicle(Brand.Toyota, Color.White);
		// Console.WriteLine(myVehicle);
		Console.WriteLine(new Car(Brand.Toyota, Color.White, "Yaris"));
	}
}
