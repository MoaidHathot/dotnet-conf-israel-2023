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
}

