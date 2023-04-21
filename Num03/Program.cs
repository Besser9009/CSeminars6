Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int GetLength(int num)
{
    int length = 1;
    for (; num > 1; length++)
    {
        num = num / 2;
    }
    return length;
}
int length = GetLength(num);
int[] GetArray(int num)
{
    int[] array = new int[length];
    for (int i = 0; i < length - 1; i++)
    {
        array[i] = num % 2;
        num = num / 2;
    }
    array[length - 1] = 1;
    Array.Reverse(array);
    return array;
}
int[] array = GetArray(num);
Console.WriteLine($"{num} = {String.Join(" ", array)}");