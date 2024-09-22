using csharp_playground.Polymorphism;


// Specify the data source.
List<int> scores = [100, 97, 92, 81, 60];

scores.Sort();

var x = from score in scores where score > 80 select score;

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

// LINQ Practices
var listOfNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 6 };
var distinctNum = listOfNumbers.Distinct().ToList();
var evenNum = listOfNumbers.Where(x => x % 2 == 0).ToList();
var numAsc = listOfNumbers.OrderBy(x => x).ToList();
var numDesc = listOfNumbers.OrderByDescending(x => x).ToList();

var first = listOfNumbers.First();

// Zip
var numbers = new List<int>() { 1, 2, 3 };
var letters = new List<char>() { 'a', 'b', 'c' };

var result = numbers.Zip(letters, (num,letter) => $"{num}-{letter}");


// Aggregate


// Select Many

var orders = new List<Order>()
{
    new Order() {Id=1, Products = new List<string>{"Rice", "Cereal"} },
    new Order() {Id=2, Products = new List<string>{"Cola"} }
};

var allProducts = orders.SelectMany(order => order.Products);


class Order
{
    public int Id { get; set; }
    public List<string> Products { get; set; }
}