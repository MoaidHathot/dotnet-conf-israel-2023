<Query Kind="Program">
  <Namespace>System.Collections.Immutable</Namespace>
</Query>

void Main()
{
	ImmutableArray<int> arr1 = new ImmutableArray<int>(){};
	ImmutableArray<int> arr2 = ImmutableArray.Create(1, 2, 3, 4, 5);
}



