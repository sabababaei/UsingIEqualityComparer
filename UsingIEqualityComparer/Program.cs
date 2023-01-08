// See https://aka.ms/new-console-template for more information

using UsingIEqualityComparer.Model;


/* this sample shows how to use IEqualityComparer to except or to distinct a list of entities based on some properties 
 * if you want to distinct/except a list base on some property using linq , you need to create a Comparer class that implements IEqualityComparer Interface.
 * then you must pass that as a new object to Distinct/except method.
 * if you want to distinct/except based on two or more properties you could compare them in Equals method in Comparer class.
 */

List<Customers> list1 = new List<Customers>()
{
new Customers(){ Name = "Saba" , Family = "bb"  , Country = "Iran" ,City = "Isfahan"}  , 
new Customers(){ Name = "Sara" , Family = "bb"  , Country = "Iran" ,City = "Kish"}  , 
new Customers(){ Name = "Eli" , Family = "ss"  , Country = "Iran" ,City = "Isfahan"}  , 
new Customers(){ Name = "Saba" , Family = "bb"  , Country = "Iran" ,City = "Tehran"}  , 
};

Console.WriteLine("------------------------------to distinct based on Name------------------------------------");
var resDistinctBasedOnOnlyName= list1.Distinct(new CustomerComparerOnName());

foreach(var item in resDistinctBasedOnOnlyName)
 Console.WriteLine(item.Name);


Console.WriteLine("------------------------------to distinct based on Name and City-----------------------------");
var resDistinctBasedOnOnlyNameAndCity= list1.Distinct(new CustomerComparerOnNameAndCity());

foreach(var item in resDistinctBasedOnOnlyNameAndCity)
 Console.WriteLine(item.Name);


 
List<Customers> list2 = new List<Customers>()
{
 new Customers(){ Name = "Saba" , Family = "eee"  , Country = "Iran" ,City = "Shiraz"}  , 
 new Customers(){ Name = "Sara" , Family = "bb"  , Country = "Iran" ,City = "Kish"}  , 
 
};


Console.WriteLine("------------------------------to Except based on Name------------------------------------");
var resExceptBasedOnOnlyName= list1.Except(list2, new CustomerComparerOnName());

foreach(var item in resExceptBasedOnOnlyName)
 Console.WriteLine(item.Name);


Console.WriteLine("------------------------------to Except based on Name and City-----------------------------");
var resExceptBasedOnOnlyNameAndCity= list1.Except(list2 ,new CustomerComparerOnNameAndCity());

foreach(var item in resExceptBasedOnOnlyNameAndCity)
 Console.WriteLine(item.Name);


Console.ReadLine();