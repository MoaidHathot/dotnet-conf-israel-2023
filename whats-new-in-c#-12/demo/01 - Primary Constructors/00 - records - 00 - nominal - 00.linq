<Query Kind="Program" />

void Main()
{
	var gandlaf = new Wizard
	{
		Name = "Mithrandir",
		Color = "Gray"
	};
}

public record Wizard 
{
	public required string Name { get; init; }
	public required string Color { get; init; }
}
