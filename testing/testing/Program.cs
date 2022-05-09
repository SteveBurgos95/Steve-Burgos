
using System;
using System.Linq;
using System.Collections;

using testing;

IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", StandardID =1,Age = 18  },
    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 ,Age = 20 },
    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 ,Age = 25 },
    new Student() { StudentID = 4, StudentName = "Ram",  StandardID =2 ,Age = 19 },
    new Student() { StudentID = 5, StudentName = "Ron", StandardID =2 ,Age = 19}
};

IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};

int[] numbers = { 5, 10, 8, 3, 6, 12 };

//Query syntax:
Console.WriteLine("Query Syntax");
IEnumerable<int> numQuery1 =
    from num in numbers
    where num % 2 == 0
    orderby num
    select num;
foreach (int i in numQuery1)
{
    Console.WriteLine(i + " ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Method Syntax");
//Method syntax:
IEnumerable<int> numQuery2 = numbers.Where(num => num % 2 == 0).OrderBy(n => n);


Console.WriteLine(System.Environment.NewLine);
foreach (int i in numQuery2)
{
    Console.WriteLine(i + " ");
}

// Uses Where Operating
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Where");
var teenAgerStudent = from s in studentList
                      where s.Age > 12 && s.Age < 20
                      select s;
Console.WriteLine("Teen age Students:");

foreach (Student std in teenAgerStudent)
{
    Console.WriteLine(std.StudentName);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
// Uses OfType()
Console.WriteLine("OfType");

IList mixedList = new ArrayList();
mixedList.Add(0);
mixedList.Add("One");
mixedList.Add("Two");
mixedList.Add(3);
mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

var stringResult = from s in mixedList.OfType<string>()
                   select s;
foreach (var str in stringResult)
    Console.WriteLine(str);


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
// Use OrderBy
Console.WriteLine("OrderBy");
var orderByResult = from s in studentList
                    orderby s.StudentName //Sorts the studentList collection in ascending order
                    select s;
foreach (var std in orderByResult)
    Console.WriteLine(std.StudentName);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
// Use OrderByDescending
Console.WriteLine("OrderByDescending");
var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
                              orderby s.StudentName descending
                              select s;
foreach (var std in orderByDescendingResult)
    Console.WriteLine(std.StudentName);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
// Use ThenBy
Console.WriteLine("ThenBy");
var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
foreach (var std in thenByResult)
    Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
// Use ThenByDescending
Console.WriteLine("ThenByDescending");
var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
foreach (var std in thenByDescResult)
    Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
// Use Reverse
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
// Use GroupBy
Console.WriteLine("GroupBy");
var groupedResult = from s in studentList
                    group s by s.Age;

foreach (var ageGroup in groupedResult)
{
    Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

    foreach (Student s in ageGroup) // Each group has inner collection
        Console.WriteLine("Student Name: {0}", s.StudentName);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
// ToLookup
Console.WriteLine("ToLookup");
var lookupResult = studentList.ToLookup(s => s.Age);
foreach (var group in lookupResult)
{
    Console.WriteLine("Age Group: {0}", group.Key);  //Each group has a key 

    foreach (Student s in group)  //Each group has a inner collection  
        Console.WriteLine("Student Name: {0}", s.StudentName);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
// Join
Console.WriteLine("Join");

var innerJoinResult = studentList.Join(// outer sequence 
              standardList,  // inner sequence 
              student => student.StandardID,    // outerKeySelector
              standard => standard.StandardID,  // innerKeySelector
              (student, standard) => new  // result selector
                      {
                  StudentName = student.StudentName,
                  StandardName = standard.StandardName
              });

foreach (var obj in innerJoinResult)
{

    Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("GroupJoin");
var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
                                std => std.StandardID, //outerKeySelector 
                                s => s.StandardID,     //innerKeySelector
                                (std, studentsGroup) => new // resultSelector 
                                {
                                    Students = studentsGroup,
                                    StandarFulldName = std.StandardName
                                });

foreach (var item in groupJoin)
{
    Console.WriteLine(item.StandarFulldName);

    foreach (var stud in item.Students)
        Console.WriteLine(stud.StudentName);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
// Select
Console.WriteLine("Select");
var selectResult = from s in studentList
                   select s.StudentName;

foreach (var name in selectResult)
{
    Console.WriteLine(name);
}