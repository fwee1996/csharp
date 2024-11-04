// //Restriction/Filtering Operations
// // Practice 1: Find the words in the collection that start with the letter 'L'
// using System.ComponentModel;
// using System.ComponentModel.DataAnnotations;

// List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

// IEnumerable<string> LFruits = from fruit in fruits 
// where fruit.StartsWith('L')
// select fruit;

// //Display
// foreach (string singleLFruit in LFruits){
// Console.WriteLine($"{singleLFruit}");
// } 





// // Practice 2: Which of the following numbers are multiples of 4 or 6
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// IEnumerable<int> fourSixMultiples = numbers.Where(n=>n%4==0 || n%6==0);

// //Display
// foreach (int singleFourSixMultiples in fourSixMultiples){
// Console.WriteLine($"{singleFourSixMultiples}");
// } 




// //Ordering Operations
// // Practice 1: Order these student names alphabetically, in descending order (Z to A)
// List<string> names = new List<string>()
// {
//     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
//     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
//     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
//     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
//     "Francisco", "Tre"
// };

// //List<string> descend = ...

//  IEnumerable<string> descend = names.OrderByDescending(name=>name);
// //.ToList(); ---IEnumerable doesnt have foreach but if you .ToList(); you can use .ForEach method chain on
// // List<string> descend = names.OrderBy(name=>name);
// //OrderDescending<string>(names=>names);

// //Display
// foreach (string name in descend){
// Console.WriteLine($"{name}");
// } 



// // Practice 2: Build a collection of these numbers sorted in ascending order
// List<int> numbers2 = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// //my ans:
// var sorted=numbers2.OrderBy(n=>n);

// //Display
// foreach (int number in sorted){
// Console.WriteLine($"{number}");
// } 






// //Aggregate Operations
// // Practice 1: Output how many numbers are in this list
// List<int> numbers3 = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// //my ans
// //Display
// Console.WriteLine("Total numbers is: ");
// Console.WriteLine(numbers3.Count());







// // Practice 2: How much money have we made?
// List<double> purchases = new List<double>()
// {
//     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
// };

// //my ans
// //Display
// Console.WriteLine($"Total money we made is: {purchases.Sum()}");







// // Practice 3: What is our most expensive product?
// List<double> prices = new List<double>()
// {
//     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
// };

// //var mostExpensive= prices.All(n>n-1);

// var sortedPrices= prices.OrderBy(n=>n);
// var mostExpensive=sortedPrices.Last();

// //------if many zeroes: Math.Round(mostExpensive,2);------
// //my ans
// //Display
// Console.WriteLine($"The most expensive is: {mostExpensive}");


//Sarah's:
//double MostExpensive=prices.OrderBy(number=>number).Last();
//or: 
//double MostExpensive=prices.Max();









// //Partitioning Operations
// //Practice 1:
// List<int> wheresSquaredo = new List<int>()
// {
//     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
// };
// /*
//     Store each number in the following List until a perfect square
//     is detected.

//     Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

//     Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
// */

//  List<int> nonSquareUpToTheFirstSquarableNum= new List<int>();


// //full sol for sqrt check:
/// rmbr: in JS .sqrt always return double so use double!!! <summary>
/// rmbr: in JS .sqrt always return double so use double!!!
/// </summary>//
// foreach (var number in wheresSquaredo)
//         {
//             // Check if the number is a perfect square
//             double sqrt = Math.Sqrt(number);
//             if (sqrt % 1 == 0) // Check if the square root is an integer
//             {
//                 // If it is a perfect square, stop adding more numbers
//                 break;
//             }
//             else
//             {
//                 // Add the number to the list
//                 nonSquareUpToTheFirstSquarableNum.Add(number);
//             }
//         }

//         // Display the result
//         Console.WriteLine($"{{ {string.Join(", ", nonSquareUpToTheFirstSquarableNum)} }}"); ////-----------------------LOOK HERE!!!!!!!
    
// //note {{ }}  to get output: { ... }





//Sarah's
//TAKEWHILE brings things out til true!
//List <int> nonSquares=wheresSquaredo.TakeWhile(square=>!(Math.Sqrt(square)%1==0)).ToList();
// //so if not a perfect sq add to list if perfect square, Break!!!!
// List <int> seriourslyNotASquare=new List<int>();
// for (int i=0;i<wheresSquaredo.COunt();i++)
// {
//     if(Math.Sqrt())
// }


//alt to TAKEWHILE:
//for (int i=0, i< whersSquaredo.Count(); i++)
//{
//if(Math.Sqrt(wheresSquaredo[i]) % 1 == 0)
    // {
    //     break;
    // }
    // seriouslyNotASquare.Add(wheresSquaredo[i]);
//}
// seriouslyNotASquare.ForEach(square => Console.WriteLine(square));











    //Using Custom Types
// Build a collection of customers who are millionaires

// //my ans:
// public class millionairesReportEntry
// {
//     public string? ReportBank { get; set; }
//     public double ReportTotalMillionaires { get; set; }
// }
// //end my ans

public class Customer
{
    public string? Name { get; set; }
    public double Balance { get; set; }
    public string? Bank { get; set; }
}

public class Program
{
    public static void Main() {
        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

        /*
    Given the same customer set, display how many millionaires per bank.
    Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

    Example Output:
    WF 2
    BOA 1
    FTB 1
    CITI 1
*/

    List<Customer> millionaires= customers.Where(c=>c.Balance>=1000000).ToList(); //rmbr .Where(n=>n) format and .ToList()!!!!

//Display millionaires:
millionaires.ForEach(singleMillionaire => Console.WriteLine(singleMillionaire.Name + " " + singleMillionaire.Balance + " " + singleMillionaire.Bank));
    
//my version:
// //Display millionaires in each bank
// List<millionairesReportEntry>millionairesReport= (
// from customer in millionaires //-----------CHECK!
// //dealing with cust list
// group customer by customer.Bank into bankGroup
// //dealing with bankGroup list

// select new millionairesReportEntry{
//     ReportBank=bankGroup.Key,
// ReportTotalMillionaires=bankGroup.Count() //----------------Count the num of millionaires! .Count
// }).ToList();

// foreach(millionairesReportEntry entry in millionairesReport){
//      Console.WriteLine($"{entry.ReportBank}, {entry.ReportTotalMillionaires}");
// }
//     }}

// ------------commented out because Program.cs cannot run more than one public class Program
// uncomment to test

IEnumerable<IGrouping<string,Customer>> longGroupedMillionaires = (from customer in millionaires group customer by customer.Bank).ToList();

    IEnumerable<IGrouping<string,Customer>> groupedMillionaires = millionaires.GroupBy(singleMillionaire => singleMillionaire.Bank).ToList();
    
    // groupedMillionaires.ToList().ForEach(x => Console.WriteLine($"{x.Key} {x.Count()} "));

    longGroupedMillionaires.ToList().ForEach(x => Console.WriteLine($"{x.Key} {x.Count()} "));

    }}


// // Challenge
// // Introduction to Joining Two Related Collections
// // As a light introduction to working with relational databases, this example works with two collections of data - banks and customers - that are related through the Bank attribute on the customer. In that attribute, we store the abbreviation for a bank. However, we want to get the full name of the bank when we produce our output.

// // This is called joining the collections together.

// // Read the Cross Join example to get started.

// // NOTE: You might also find this page on the Microsoft Docs site helpful.

// // Enumerable.Join Method
// /*
//     TASK:
//     As in the previous exercise, you're going to output the millionaires,
//     but you will also display the full name of the bank. You also need
//     to sort the millionaires' names, ascending by their LAST name.

//     Example output:
//         Tina Fey at Citibank
//         Joe Landy at Wells Fargo
//         Sarah Ng at First Tennessee
//         Les Paul at Wells Fargo
//         Peg Vale at Bank of America
// */

// //Solution:
// // To join the two collections (banks and customers) and generate a report that shows millionaires with the full name of the bank, you need to follow these steps:

// // Filter out customers who are millionaires.
// // Join the filtered list of millionaires with the list of banks based on the bank symbol.
// // Sort the resulting list of millionaires by their last name.
// // Projects the result into a ReportItem object, and converts the result to a list.
// // Display the report.
        
// //my ans:
// public class ReportItem
// {
//     public string? CustomerName { get; set; }
//     public string? BankName { get; set; }
// }
// //end my ans


// // Define a bank
// public class Bank
// {
//     public string? Symbol { get; set; }
//     public string? Name { get; set; }
// }

// // Define a customer
// public class Customer
// {
//     public string? Name { get; set; }
//     public double Balance { get; set; }
//     public string? Bank { get; set; }
// }

// public class Program
// {
//     public static void Main() {
//         // Create some banks and store in a List
//         List<Bank> banks = new List<Bank>() {
//             new Bank(){ Name="First Tennessee", Symbol="FTB"},
//             new Bank(){ Name="Wells Fargo", Symbol="WF"},
//             new Bank(){ Name="Bank of America", Symbol="BOA"},
//             new Bank(){ Name="Citibank", Symbol="CITI"},
//         };

//         // Create some customers and store in a List
//         List<Customer> customers = new List<Customer>() {
//             new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
//             new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
//             new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
//             new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
//             new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
//             new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
//             new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
//             new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
//             new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
//             new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
//         };

//         /*
//             You will need to use the `Where()`
//             and `Select()` methods to generate
//             instances of the following class.

//             public class ReportItem
//             {
//                 public string CustomerName { get; set; }
//                 public string BankName { get; set; }
//             }
//         */

// // Filter millionaires:
// //ALt: List<Customer> millionaires= customers.Where(c=>c.Balance>=1000000).ToList();
// // .ToList() is necessary to convert the IEnumerable<Customer> from .Where usage to a List<Customer>.
// var millionaires= customers.Where(c=>c.Balance>=1000000); //rmbr .Where(n=>n) format 

// // Join millionaires with banks and create report items:
// //ALt: List<ReportItem> ..
// var millionaireReport = millionaires.Join( // join the millionaires collection with the banks collection on the Bank symbol.
//             banks,
//             customer => customer.Bank, //Specifies the key selector for the customers (the bank symbol).
//             bank => bank.Symbol, //Specifies the key selector for the banks (the bank symbol).
//             (customer, bank) => new {
//                 CustomerName = customer.Name,
//                 BankName = bank.Name
//             })// Defines the result of the join as an anonymous object containing the customer's name and the bank's name.
//             .OrderBy(item => item.CustomerName?.Split(' ').Last()) // Sort by last name // The Split(' ') method is used to get the last part of the name string.
//             .Select(item => new ReportItem { //Select--create new instances of ReportItem with the customer's full name and the bank's full name.
//                 CustomerName = item.CustomerName,
//                 BankName = item.BankName
//             })
//             .ToList(); //Converts the result to a list.

//         //Display
//         foreach (var item in millionaireReport)
//         {
//             Console.WriteLine($"{item.CustomerName} at {item.BankName}");
//         }
//     }
// }







