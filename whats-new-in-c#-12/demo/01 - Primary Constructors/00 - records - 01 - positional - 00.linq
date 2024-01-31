<Query Kind="Program" />

void Main()
{
	var gandlaf = new Wizard("Mithrandir", "Gray");
}

public record Wizard(string Name, string Color);
