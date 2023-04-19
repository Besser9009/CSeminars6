Console.Clear();
// int [] NewArray()
// {
//     int n = 1;
//     int[] array = new int[3];
//     for (int i = 0; i < 3; i++)
//     {
//         Console.Write($"Введите длину {n} стороны: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//         n++;
//     }
//     return array;
// }
// int[] array = NewArray();
// System.Console.WriteLine($"[{String.Join(", ", array)}]");
Console.Write("Введите три числа (через запятую): ");
int[] array = Console.ReadLine().Split(',').Select(num => int.Parse(num)).ToArray();
void Triangle(int[] array)
{
    string msg = (array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[1] + array[0]) ? "Yes, it's triangle" : "No... It's not triangle";
    Console.WriteLine(msg);
}
Triangle(array);
