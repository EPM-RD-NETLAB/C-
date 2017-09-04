<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

static dynamic Mean (dynamic x, dynamic y)
{
	return (x + y) / 2;
}

static int Mean(char x, char y)
{
	"char->".Dump();
	return (x + y) / 2;
}

static void Main()
{ 
	Console.WriteLine (Mean (3, 6));
	Console.WriteLine (Mean (3f, 6f));		// float
	Console.WriteLine (Mean (3.0, 6.0));	// double
	Console.WriteLine (Mean (3m, 6m));		// decimal
	Console.WriteLine (Mean ('3', '6'));	// char :)
	//Console.WriteLine (Mean ("string", true));	// ?
}