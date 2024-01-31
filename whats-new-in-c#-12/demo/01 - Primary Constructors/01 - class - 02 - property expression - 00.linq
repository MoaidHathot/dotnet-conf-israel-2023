<Query Kind="Program" />

void Main()
{
	var c = "Gray";
	
	var gandlaf = new Wizard("Mithrandir", c)
	{
		ValinorName = "Olórin",
	};
}

public class Wizard(string _name, string _color)
{
	public required string ValinorName { get; init; }
	
	public string Name { get; } = _name;
	public string Color => _color;
}
