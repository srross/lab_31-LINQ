
//LAB 31 - LINQ
//Task: Use Linq to search the following collections.

// Build Specifications: Assume we have the following collections: 
int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

//Answer the following questions: 
//For nums: 

//Find the Minimum value
var minNum = nums.Min();
Console.WriteLine($"Minimum value = {minNum}");

//Find the Maximum value
var maxnNum = nums.Max();
Console.WriteLine($"Maximum value = {maxnNum}");

//Find the Maximum value less than 10000
var maxLess1000 = nums.Where(x => x < 1000).Max();
Console.WriteLine($"maxLess1000 value = {maxLess1000}");

//Find all the values between 10 and 100
var range = nums.Where(x => x > 10 && x < 100);
Console.WriteLine($"range for x > 10 && x < 100 returns no values {String.Join(",", range)}");

//Find all the Values between 100000 and 999999 inclusive 
//Count all the even numbers 

Console.ReadLine();