<Query Kind="Program" />

void Main()
{
	var arr = new []{ 1, 2, 3, 4, 5, 6 };
	
	arr[^3].Dump();
	arr[1..3].Dump();
	arr[..4].Dump();
	arr[2..].Dump();
	arr[new Range(0, 3)].Dump();
	arr[new Index(3, fromEnd: true)].Dump();
	
	var fellowship = new FellowshipOftheRing();
	
	fellowship[new Index(2)].Dump();
	fellowship[new Index(2, fromEnd: true)].Dump();
	fellowship[^2].Dump();
	fellowship[1..].Dump();
	fellowship[..3].Dump();
	fellowship[..].Dump();
}

public class FellowshipOftheRing
{
	private string[] _members = { "Gandalf", "Samwise Gamgee", "Frodo Beggins", "Peregrin Took", "Meriadoc Brandybuck", "Aragorn", "Boromir", "Legolas", "Gimli" };
	
	public int Length => _members.Length;
	
	public string this[int index] => _members[index];
	
	public IEnumerable<string> Slice(int start, int end)
		=> _members[start..end];
}

