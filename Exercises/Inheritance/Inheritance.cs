#pragma warning disable CS8618

enum Brand {
	BMW, Volvo, Opel, Tesla, Audi, Toyota
}

enum Color {
	Red, Black, Violet, Green, Blue, White
}

class Vehicle {
	Random rnd = new Random();
	public Brand _brand { get; set; }
	public Color _color { get; set; }
	public Size Dimensions { get; set; }

	public Vehicle() {
		Dimensions = new Size {
			_length = 1.5 + rnd.NextDouble() * 2,
			_width = 1 + rnd.NextDouble() * 2,
			_height =  0.5 + rnd.NextDouble() * 2
		};
	}

	public Vehicle(Brand brand, Color color) {
		_brand = brand;
		_color = color;
	}

	public override string ToString() {
		return $"A {_color} {_brand}";
	}

}

class Car : Vehicle {
	public string _model;


	public string Model { get => _model; set => _model = value; }

	public Car(Brand brand, Color color, string model) {
		_brand = brand;
		_color = color;
		_model = model;
	}

	public override string ToString() {
		return $"A {_color} {Dimensions._length:f2}m {_model} from {_brand}";
	}
}

struct Size {
	public double _length { get; set; }
	public double _width { get; set; }
	public double _height { get; set; }

	public Size(double length, double width, double height) {
		_length = length;
		_width = width;
		_height = height;
	}
}
