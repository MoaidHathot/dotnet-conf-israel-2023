<Query Kind="Program" />

void Main()
{
	int[] arr0 = [];
	int[] arr1 = [1, 2, 3, 4];
	List<int> list1 = [1, 2, 3, 4];

	int[] arr2 = [..arr1];
	int[] arr3 = [0, ..arr1];
	int[] arr4 = [..list1, 2, ..arr1];
}

