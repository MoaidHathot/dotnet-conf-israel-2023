<Query Kind="Program" />

void Main()
{
	var c = "Gray";
	
	var gandalf = new Wizard("Mithrandir", c)
	{
		ValinorName = "Olórin",
	};
	
	gandalf.Dump();
	gandalf.DivineTransform();
	gandalf.Dump();
}

public class Wizard(string _name, string _color)
{
	public required string ValinorName { get; init; }
	
	public string Name { get; } = _name;
	public string Color => _color;
	
	public void DivineTransform()
	{
		_color = "Whtie";
	}
}
