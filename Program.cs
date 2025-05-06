Console.Write("How many numbers to print: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers_Recursive(n);

void PrintNaturalNumbers_Recursive(int n)
{
    if (n > 0)
    {
        PrintNaturalNumbers_Recursive(n - 1);
        Console.Write($"{n} ");
    }
}