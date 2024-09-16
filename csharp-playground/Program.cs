using csharp_playground.Polymorphism;


// Specify the data source.
List<int> scores = [100, 97, 92, 81, 60];

scores.Sort();

var x  = from score in scores where score > 80 select score;

// Define the query expression.
IEnumerable<string> scoreQuery =
    from score in scores
    where score > 80
    orderby score ascending
    select $"Score {score}";

// Execute the query.
foreach (var i in scoreQuery)
{
    Console.WriteLine(i + " ");
}

// Output: 97 92 81


// Object substitution class
ParentClass cl = new DerivedClass();
cl.DoWork();
