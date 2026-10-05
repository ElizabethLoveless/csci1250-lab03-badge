/* 
* Name: Elizabeth Loveless
* Course: CSCI1250, Section 001
* Assignment: Lab 3, The Badge Office
* Date: September 30th, 2026
* Description: Builds a students badge from name, two random assignments, and the walking distance to a first class 
*/

using System.Runtime.CompilerServices;

Random rng = new Random();

Console.WriteLine("===Part 1: The Name ===");

Console.Write("Full name:");
string fullName = Console.ReadLine();
fullName= fullName.Trim();
int spacePosition = fullName.IndexOf ("");

string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring (spacePosition +1);
string badgeName = fullName.ToUpper();
string username = firstName.Substring (0,1).ToLower()+ lastName.ToLower();
string initials = firstName.Substring (0,1).ToUpper() + lastName.Substring (0,1).ToUpper();
int lastNameLetters = lastName.Length; 

Console.WriteLine("Name on Badge:" + badgeName);
Console.WriteLine("Username:" + username);
Console.WriteLine("Initials:" + initials);
Console.WriteLine("Letters in last name:" + lastNameLetters);
Console.WriteLine();

Console.WriteLine("===Part 2: The Numbers ===");

int studentID = rng.Next(100000, 1000000);
int locker = rng.Next(1,501);
Console.WriteLine();

Console.WriteLine("===Part 3: The Walk ===");

Console.WriteLine("Dorm X:");
double dormX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Dorm Y:");
double dormY = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Class X:");
double classX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Class Y:");
double classY = Convert.ToDouble(Console.ReadLine());
double speed = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

