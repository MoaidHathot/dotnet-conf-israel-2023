<Query Kind="Program" />

using unsafe AgePointer = int*;
using unsafe StringPointer = string*;

void Main()
{
	var name = "Frieren";
	var age = 1_000;
	
	unsafe
	{
		AgePointer agePtr = &age;
		StringPointer namePtr = &name;
	}
}