<Query Kind="Program" />

void Main()
{
	FellowshipOftheRing f0 = [];
	FellowshipOftheRing f1 = ["Gandalf", "Samwise Gamgee", "Frodo Beggins", "Peregrin Took", "Meriadoc Brandybuck", "Aragorn", "Boromir", "Legolas", "Gimli"];
}

public class FellowshipOftheRing : IEnumerable<string>
{
	private List<string> _members = new();
	public int Length => _members.Count;

	public FellowshipOftheRing()
	{
	}

	public FellowshipOftheRing(int capacity)
		=> _members = new List<string>(capacity);

	public FellowshipOftheRing(IEnumerable<string> names)
		=> _members = new List<string>(names);

	public void Add(string name)
	{
		var before = _members.Capacity;
		_members.Add(name);
		var after = _members.Capacity;
		
		(before, after, _members.Count).Dump();
	}

	public IEnumerator<string> GetEnumerator()
		=> _members.GetEnumerator();
		
	IEnumerator IEnumerable.GetEnumerator()
		=> GetEnumerator();
}

