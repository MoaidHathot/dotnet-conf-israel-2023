<Query Kind="Program" />

using AgePointer = int*;
using StringPointer = string*;

void Main()
{
	var name = "Frieren";
	var age = 1_000;
	
	unsafe
	{
		int* agePtr = &age;
		string* namePtr = &name;
	}
}