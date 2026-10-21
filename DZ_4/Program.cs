int[] numbers = { 10, 20, 30, 40, 50 };

int empty;
int len = numbers.Length;
int middle = len / 2;

for (int i = 0; i < middle; i++)
{
    empty = numbers[i];
    numbers[i] = numbers[len - i - 1];
    numbers[len - i - 1] = empty;
}

Console.Write("Изначальный массив: ");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

Console.Write("Измененный массив: ");
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();