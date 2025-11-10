Console.Write("Enter a number N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= N; i++)
{
    sum += i;
}
Console.WriteLine("Sum from 1 to " + N + " = " + sum);
Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");
int num = 1;
while (num <= 20)
{
    if (num % 4 == 0)
    {
        num++;
        continue;
    }
    if (num == 15)
        break;

    Console.WriteLine(num);
    num++;
}

int[] numbers = { 2, 4, 6, 8, 10 };
int total = 0;

foreach (int value in numbers)
{
    total += value;
}
Console.WriteLine("\nSum of all elements in array = " + total);