# UsingIEqualityComparer

 This sample shows how to use IEqualityComparer to except or to distinct a list of entities based on some properties. 
 If you want to distinct/except a list based on some properties using Linq , you need to create a Comparer class that implements IEqualityComparer Interface.
 Then you must pass that as a new object to Distinct/except method.
 If you want to distinct/except based on two or more properties you could compare them in Equals method in Comparer class.
 
 
