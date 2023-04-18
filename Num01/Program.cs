Console.Clear();
int[] GetArray(int length, int minValue, int maxValue)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}
int[] array = GetArray(11, 1, 100);
System.Console.WriteLine($"[{String.Join(", ", array)}]");
// Array.Reverse(array);
// System.Console.WriteLine($"[{String.Join(", ", array)}]");

int[] Reverce1(int[] array)
{
    int[] reverse = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        reverse[i] = array[array.Length - 1 - i];
    }
    return reverse;
}
// int[] reverse = Reverce1(array);
// System.Console.WriteLine($"[{String.Join(", ", reverse)}]");

void Reverce2(int[] array)
{
    int count = 0;
    if (array.Length % 2 == 0) count = array.Length / 2;
    else count = array.Length / 2 + 1;
    for (int i = 0; i < count; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}
Reverce2(array);
System.Console.WriteLine($"[{String.Join(", ", array)}]");