#pragma warning disable CS8618

enum Brand {
	BMW, Volvo, Opel, Tesla, Audi, Toyota
}

enum Color {
	Red, Black, Violet, Green ,Blue, White
}

class Vehicle {
	private Brand _brand;
	private Color _color;

	public Vehicle() {

	}

	public Vehicle(Brand brand, Color color) {
		_brand = brand;
		_color = color;
	}

	public override string ToString() {
		return $"A {_color} {_brand}";
	}
}
