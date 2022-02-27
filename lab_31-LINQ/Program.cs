
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

//----------------------------------------------------------------------------------

/*
Make a Student class with the following properties: 
Name 
Age 

For students: 
	Find all students age of 21 and over (aka US drinking age) 
	Find the oldest student 
	Find the youngest student
	Find the oldest student under the age of 25 
	Find all students over 21 and with even ages
	Find all teenage students (13 to 19 inclusive) 
	Find all students whose name starts with a vowel
 */
List<Student> students = new List<Student>();
students.Add(new Student("Jimmy", 13));
students.Add(new Student("Hannah", 21));
students.Add(new Student("Justin", 30));
students.Add(new Student("Sarah", 53));
students.Add(new Student("Hannibal", 15));
students.Add(new Student("Phillip", 16));
students.Add(new Student("Maria", 63));
students.Add(new Student("Abe", 33));
students.Add(new Student("Curtis", 10));



public class Student
{
	public Student(string name, int age)
	{

	}
	public string Name { get { return Name; } }
	public int Age { get { return Age; } }
}


