<Query Kind="Program" />

void Main()
{
	var gandlaf = new Wizard("Mithrandir", "Gray")
	{
		ValinorName = "Olórin",
	};
}

public class Wizard(string _name, string _color)
{
	public required string ValinorName { get; init; }
}
