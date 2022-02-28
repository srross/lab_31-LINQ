
/*****************************************************************
 * LAB 31 - 
 * LINQ Part I      Due Thursday 02/24/2022 - Task: Use Linq to search the nums[] array
 * LINQ PART II     Due Monday 02/28/2022   - Task: Use Linq to search the students<Students> list
 *                                                  Make a Student class with the following properties: Name, Age
 * **************************************************************/

Console.WriteLine(" ******************** LINQ lab Part I ******************** ");

int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };


//Find the Minimum value
var minValue = nums.Min();
Console.WriteLine($"Minimum value = {minValue}");
Console.WriteLine();


//Find the Maximum value
var maxValue = nums.Max();
Console.WriteLine($"Maximum value = {maxValue}");
Console.WriteLine();


//Find the Maximum value less than 10000
var maxValueLessThan10K = nums.Where(x => x < 10000).Max();
Console.WriteLine($"maxLess1000 value = {maxValueLessThan10K}");
Console.WriteLine();


//Find all the values between 10 and 100
var rangeValuesBtw = nums.Where(x => x > 10 && x < 100);
Console.WriteLine($"range for x > 10 && x < 100 returns no values {String.Join(",", rangeValuesBtw)}");
Console.WriteLine();


//Find all the Values between 100000 and 999999 inclusive 
var rangeValuesInclusive = nums.Where(x => x >= 100000 && x <= 999999);
Console.WriteLine($"rang for all the Values between 100000 and 999999 inclusive = {String.Join(" - ", rangeValuesInclusive)}");
Console.WriteLine();


//Count all the even numbers 
var countEvenValues = nums.Count(x => x % 2 == 0);
Console.WriteLine($"count for all the even numbers = {countEvenValues}");
Console.WriteLine();

countEvenValues = nums.Where(x => x % 2 == 0).Count();
Console.WriteLine($"count for all the even numbers = {countEvenValues}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();




/*****************************************************************
 * LAB 31 - LINQ - PART 2 Due Monday 02/28/2022
 * Task : 
 *      Use Linq to search the following collections. 
 *      Make a Student class with the following properties: Name, Age
 *****************************************************************/

Console.WriteLine(" ******************** LINQ lab Part II ******************** ");

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


/* ************************************************************
 * Find all students age of 21 and over (aka US drinking age) 
 */

var age21andOver = students.Where(s => s.Age >= 21);

Console.WriteLine("Here is the list of students aged 21 and over:");
foreach (var s in age21andOver)
{
    Console.WriteLine(s.Name);
}
Console.WriteLine();


/* *******************************************
 * Find the oldest student 
 *  https://stackoverflow.com/questions/9114863/linq-using-max-to-select-a-single-row 
 */

var oldest = students.Where(x => x.Age == students.Max(x => x.Age)).SingleOrDefault().Name; 
Console.WriteLine($"The name of the oldest student is: {oldest}");

var oldestName = students.OrderByDescending(s => s.Age).FirstOrDefault();
Console.WriteLine($"Another way to print the name of the oldest student is: {oldestName.Name}");
Console.WriteLine();


/* *******************************************
 * Find the youngest student 
 */

var youngest = students.Where(x => x.Age == students.Min(x => x.Age)).SingleOrDefault().Name;
Console.WriteLine($"The name of the youngest student is: {youngest}");


var youngestName = students.OrderBy(s => s.Age).FirstOrDefault().Name;
Console.WriteLine($"Another way to print the name of the youngest student is: {youngestName}");
Console.WriteLine();



/* *******************************************
 * Find the oldest student under the age of 25 
 * 
 * NOTE - var oldestUnder25Age = students.Where(x => x.Age < 25).Max(x => x.Age); 
 * only returns age, I need it to return name 
 * still figuring out how to do this with a single linq query
*/

var allUnder25 = students.Where(x => x.Age < 25);
var oldestUnder25Name = allUnder25.SingleOrDefault(x => x.Age == allUnder25.Max(x => x.Age)).Name; 
Console.WriteLine($"The name of the oldest student under 25 is: {oldestUnder25Name}");
Console.WriteLine();


/* ********************************************
 * Find all students over 21 and with even ages
*/

var evenAgeOver21 = students.Where(x => x.Age > 21 && x.Age % 2 == 0);

Console.WriteLine("Students over 21 and with even ages:");
Console.WriteLine("====================================");
foreach (var s in evenAgeOver21)
{

    Console.WriteLine(s.Name);
}
Console.WriteLine();


/* **********************************************
 * Find all teenage students (13 to 19 inclusive) 
 */

var teenagers = students.Where(x => x.Age >= 13 && x.Age < 20);

Console.WriteLine("All teenage students (13 to 19 inclusive):");
Console.WriteLine("====================================");
foreach (var s in teenagers)
{   
    Console.WriteLine(s.Name);
}
Console.WriteLine();


/* ************************************************
 * Find all students whose name starts with a vowel
 */

var nameStartsWithVowel = students.Where(x => x.Name.ToLower().StartsWith("a")
                                            || x.Name.ToLower().StartsWith("e")
                                            || x.Name.ToLower().StartsWith("i")
                                            || x.Name.ToLower().StartsWith("o")
                                            || x.Name.ToLower().StartsWith("u"));

Console.WriteLine("Students whose name starts with a vowel:");
Console.WriteLine("====================================");
foreach (var s in nameStartsWithVowel)
{
    Console.WriteLine(s.Name);
}
Console.WriteLine();


Console.ReadLine();


/* ***************************************** 
 */
public class Student
{
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }
}