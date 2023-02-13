Console.WriteLine("Сколько чисел будет?");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

void main()
{
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число:");
    int a = Convert.ToInt32(Console.ReadLine());
    array [i] = a;
}
}

void result()
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    Console.WriteLine($"Чисел больше 0: {count}");
}
main();
result();