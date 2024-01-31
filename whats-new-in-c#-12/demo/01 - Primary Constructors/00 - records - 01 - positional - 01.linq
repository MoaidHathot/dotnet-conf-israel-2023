<Query Kind="Program" />

void Main()
{
	var gandlaf = new Wizard("Mithrandir", "Gray")
	{
		ValinorName = "Olórin",
	};
}

public record Wizard(string Name, string Color)
{
	public required string ValinorName { get; init; }
}
