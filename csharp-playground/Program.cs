using csharp_playground.Polymorphism;


//// Specify the data source.
//List<int> scores = [100, 97, 92, 81, 60];

//scores.Sort();

//var x  = from score in scores where score > 80 select score;

//// Define the query expression.
//IEnumerable<string> scoreQuery =
//    from score in scores
//    where score > 80
//    orderby score ascending
//    select $"Score {score}";

//// Execute the query.
//foreach (var i in scoreQuery)
//{
//    Console.WriteLine(i + " ");
//}

//// Output: 97 92 81


//// Object substitution class
//ParentClass cl = new DerivedClass();
//cl.DoWork();

// LINQ Practices
var listOfNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 6 };
var distinctNum = listOfNumbers.Distinct().ToList();
var evenNum = listOfNumbers.Where(x => x % 2 == 0).ToList();
var numAsc = listOfNumbers.OrderBy(x => x).ToList();
var numDesc = listOfNumbers.OrderByDescending(x => x).ToList();

var first = listOfNumbers.First();