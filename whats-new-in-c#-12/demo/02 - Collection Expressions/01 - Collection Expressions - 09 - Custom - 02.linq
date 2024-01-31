<Query Kind="Program">
  <Namespace>System.Runtime.InteropServices</Namespace>
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

void Main()
{
	FellowshipOfTheRing f0 = [];
	FellowshipOfTheRing f1 = ["Gandalf", "Samwise Gamgee", "Frodo Beggins", "Peregrin Took", "Meriadoc Brandybuck", "Aragorn", "Boromir", "Legolas", "Gimli"];
}

[CollectionBuilder(typeof(FellowshipOfTheRingBuilder), nameof(FellowshipOfTheRingBuilder.Create))]
public class FellowshipOfTheRing : IEnumerable<string>
{
	private List<string> _members = new();
	public int Length => _members.Count;

	public FellowshipOfTheRing()
	{
	}

	public FellowshipOfTheRing(int capacity)
		=> _members = new List<string>(capacity);

	public FellowshipOfTheRing(IEnumerable<string> names)
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

public static class FellowshipOfTheRingBuilder
{
	public static FellowshipOfTheRing Create(ReadOnlySpan<string> members)
	{
		var f = new FellowshipOfTheRing(members.Length);
		foreach(var member in members)
		{
			f.Add(member);
		}
		
		return f;
	}
}