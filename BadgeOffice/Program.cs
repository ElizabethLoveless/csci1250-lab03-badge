/* 
* Name: Elizabeth Loveless
* Course: CSCI1250, Section 001
* Assignment: Lab 3, The Badge Office
* Date: September 30th, 2026
* Description: Builds a students badge from name, two random assignments, and the walking distance to a first class 
*/


Random rng = new Random();

Console.WriteLine("===Part 1: The Name ===");

Console.Write("Full name: ");
string fullName = Console.ReadLine();
fullName= fullName.Trim();
int spacePosition = fullName.IndexOf (" ");

string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring (spacePosition +1);

string badgeName = fullName.ToUpper();
string username = firstName.Substring (0,1).ToLower()+ lastName.ToLower();
string initials = firstName.Substring (0,1).ToUpper()+ "." + lastName.Substring (0,1).ToUpper() +".";
int lastNameLetters = lastName.Length; 

Console.WriteLine("Name on Badge:" + badgeName);
Console.WriteLine("Username:" + username);
Console.WriteLine("Initials:" + initials);
Console.WriteLine("Letters in last name:" + lastName.Length);
Console.WriteLine();

Console.WriteLine("===Part 2: The Numbers ===");

int studentId = rng.Next(100000, 1000000);
int locker = rng.Next(1,501);
Console.WriteLine("Student ID: "+ studentId);
Console.WriteLine("Locker: " + locker);
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
Console.WriteLine("Walking speed in feet per second: ");
double speed = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double x = Math.Pow(classX-dormX, 2);
double y = Math.Pow(classY-dormY, 2);
double distance = Math.Sqrt(x+y);
distance = Math.Round(distance, 1);

int totalSeconds = Convert.ToInt32 (Math.Round(distance / speed));
int minutes = totalSeconds / 60;
int secondsLeft = totalSeconds % 60;

Console.WriteLine("Distance: " + distance + "feet");
Console.WriteLine("Walk time:" + minutes + "minutes" + secondsLeft + "seconds");
Console.WriteLine();

//=== Part 4:===//
const string line = " =================================="; //34 characters
const int label_width = 10;
int checkDigit = studentId % 9;

Console.WriteLine(line);
Console.WriteLine("        ETSU STUDENT BADGE");
Console.WriteLine(line);

Console.WriteLine("NAME" .PadRight(label_width) + badgeName);
Console.WriteLine("USERNAME" .PadRight(label_width) + username);
Console.WriteLine("ID" .PadRight(label_width) + studentId + "-" + checkDigit); 
Console.WriteLine("LOCKER" .PadRight(label_width) + locker);
Console.WriteLine("WALK" .PadRight(label_width) + minutes + "min" + secondsLeft + "sec");
Console.WriteLine(line);
