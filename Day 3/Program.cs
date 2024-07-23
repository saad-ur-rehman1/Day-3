// See https://aka.ms/new-console-template for more information

// Nested for Loops
/* every loop has these following three steps
 Starting point
 Condition
Increment/Decrement*/

/*for (int outerLoop = 0; outerLoop < 5; outerLoop++)
{
    for (int innerLoop = 0; innerLoop < 5; innerLoop++)
    {
        Console.WriteLine($"Outer: {outerLoop} && Inner : {innerLoop}");
    }
}*/
// See https://aka.ms/new-console-template for more information

// While Loop
/*int start = 0;
while (start<5)// condition
{
    start++; // increment
    Console.WriteLine(start);
   // start++; // increment
}*/
// Data structures (List)
/* List<int> marks = new List<int> { 78, 92, 100, 37, 81 };

* for (int i = 0; i < 5; i++) // you can also use i< marks.count (it is better approach bcz we will not count numbers in the list, it is calculated automatically)
 {
     Console.WriteLine(marks[i]);
 }*/

/*List<int> marks = new List<int>
{
    78,
    92,
    100
};
int i = 0;
while (i < marks.Count)
{
    Console.WriteLine(marks[i]);
    i++;
}*/

using System.Linq;

/*List<string> name=new List<string> // Print names
{
    "Arslan", "Ahsan", "Saad"
};
for(int i=0; i<name.Count; i++)
{
    Console.WriteLine(name[i]);
}
*/
/*List<string> name = new List<string> // print names in a reverse pattern
{
    "Arslan", "Ahsan", "Saad"
};
for (int i = name.Count-1; i > -1; i--)
{
    Console.WriteLine(name[i]);
}*/
/*List<int> marks = new List<int> // Print marks in a reverse pattern
{
    77, 88, 99
};
for (int i = marks.Count - 1; i > -1; i--)
{
    Console.WriteLine(marks[i]);
}*/