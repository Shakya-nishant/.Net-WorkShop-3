Console.WriteLine("Enter Your Age");
int Age = Convert.ToInt32(Console.ReadLine());
if (Age < 13)
{
    Console.WriteLine("Child");
}
else if (Age >= 13 || Age <= 19)
{
    Console.WriteLine("TeenAge");
}
else
{
    Console.WriteLine("Adult");
}