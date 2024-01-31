<Query Kind="Program">
  <Namespace>System.Collections.Immutable</Namespace>
</Query>

void Main()
{
	ImmutableList<int> arr1 = ImmutableList.Create<int>();
	ImmutableList<int> arr2 = ImmutableList.Create(1, 2, 3, 4, 5);
	
	ImmutableList<int> arr3 = [];
	ImmutableList<int> arr4 = [1, 2, 3, 4];
}