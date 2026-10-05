
/*
*Name:          Michael Merendino
*Course:        CSCI 1250, section 001
*Assignment:    Lab 03, The Bagde Office
*Date:          September 30, 2026
*Description:   The builds a students badge from a name, two random assignments,
*               and the walking distance to a first class.
*/

//============ part 1 ==============

using System.Diagnostics;
using System.Security.Cryptography;

System.Console.WriteLine("What is the students full name?");

string fullName = Console.ReadLine();

fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");

string firstName = fullName.Substring(0,spacePosition);

string lastName = fullName.Substring(spacePosition + 1);

System.Console.WriteLine("Name on badge: " + fullName.ToUpper());

System.Console.WriteLine("Username: " + firstName.Substring(0,1) + lastName);

System.Console.WriteLine("initials: " + firstName.Substring(0,1).ToUpper() + "." + lastName.Substring(0,1).ToUpper() + ".");

System.Console.WriteLine("letters in last name: " + lastName.Length);

//=========== part 2 =============

Random rng = new Random();

System.Console.WriteLine();
System.Console.WriteLine("student ID: " + rng.Next(100000,1000000));

System.Console.WriteLine("locker: " + rng.Next(1,501));
System.Console.WriteLine();

//========= part 3 ===============

double classX, classY;
double dormX, dormY;
double speed;
double distance;
double time;

System.Console.WriteLine("Whats the dorms X?");
dormX = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Whats the dorms Y?");
dormY = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Whats the classroom's X?");
classX = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Whats the classroom's Y?");
classY = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Whats your walking speed in feet per second?");
speed = Convert.ToDouble(Console.ReadLine());


distance = Math.Sqrt(Math.Pow(classX - dormX, 2) + Math.Pow(classY - dormY, 2));

time = distance / speed;

int totalSeconds = (int)Math.Round(time);
int minutes = totalSeconds / 60;
int second = totalSeconds % 60;

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("Distance: " + distance.ToString("F1") + " feet");
System.Console.WriteLine("Time: " + minutes  + " minutes\t" + second + " seconds");
System.Console.WriteLine();
System.Console.WriteLine();

System.Console.WriteLine("==============================");
System.Console.WriteLine("      ETSU STUDENT BADGE");
System.Console.WriteLine("==============================");
System.Console.WriteLine("NAME\t   " + fullName.ToUpper());
System.Console.WriteLine("USERNAME   " + firstName.Substring(0,1) + lastName);
System.Console.WriteLine("ID\t   " + rng.Next(100000,1000000));
System.Console.WriteLine("LOCKER\t   " + rng.Next(1,501));
System.Console.WriteLine("WALK\t   " + minutes  + " min     " + second + " sec");
System.Console.WriteLine("==============================");