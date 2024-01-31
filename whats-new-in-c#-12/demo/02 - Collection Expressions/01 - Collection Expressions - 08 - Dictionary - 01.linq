<Query Kind="Program">
  <Namespace>System.Collections.Immutable</Namespace>
</Query>

void Main()
{
	Dictionary<int, string> map = [new KeyValuePair<int, string>(1, "One")];
	Dictionary<int, string> map2 = [new (1, "One"), new (2, "Two")];
	
	Dictionary<int, string> map3 = [..map, ..map2];
}

public static class Extensions
{
	public static void Add<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> keyValuePair)
	{
		dictionary.Add(keyValuePair);
	}
}