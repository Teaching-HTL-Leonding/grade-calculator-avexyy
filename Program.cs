int possiblePoints = 80;
double percentage  = 0;
int totalPoints = 0;
int grade = 0;

System.Console.Write("Did you participate in the first written exam? (yes/no) ");
string decision = Console.ReadLine()!;

if(decision == "yes" || decision == "YES")
{
    System.Console.Write("How many points(0-20) did you have in the first written exam? ");
    totalPoints = int.Parse(Console.ReadLine()!);
}
else{possiblePoints -= 20;}

System.Console.Write("Did you participate in the second written exam? (yes/no) ");
decision = Console.ReadLine()!;

if(decision == "yes" || decision == "YES")
{
    System.Console.Write("How many points(0-20) did you have in the second written exam? ");
    totalPoints += int.Parse(Console.ReadLine()!);
}
else{possiblePoints -= 20;}

System.Console.Write("How many points(0-20) did you get through homeworks? ");
totalPoints += int.Parse(Console.ReadLine()!);

System.Console.Write("Did you have an oral exam? (yes/no) ");
decision = Console.ReadLine()!;

if(decision == "yes" || decision == "YES")
{
    System.Console.Write("How many points(0-20) did you get for the oral exam? ");
    totalPoints += int.Parse(Console.ReadLine()!);
}
else{possiblePoints -= 20;}

percentage = 100d * totalPoints / possiblePoints;

/*
double percentageTwo = 0;
int betterGrade = 0;


if( <hier müssten die erreichten Punkte der Hausübung stehen> < 20)   
{
    percentageTwo = 100d * totalPoints / possiblePoints;

    if(percentageTwo >= 89) {betterGrade = 1;}
    else if(percentageTwo >= 76) {betterGrade = 2;}
    else if(percentageTwo >= 63) {betterGrade = 3;}
    else if(percentageTwo >= 50) {betterGrade = 4;}
    else {betterGrade = 5;}
}
*/

if(percentage >= 89) {grade = 1;}
else if(percentage >= 76) {grade = 2;}
else if(percentage >= 63) {grade = 3;}
else if(percentage >= 50) {grade = 4;}
else {grade = 5;}

System.Console.WriteLine($"Your achieved grade is: {grade} ");

/*
if(betterGrade < grade)
{
    System.Console.WriteLine($"If you had achieved all the points in the homework you could have gotten the grade: {betterGrade}");
}
*/