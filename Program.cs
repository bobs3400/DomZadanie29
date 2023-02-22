Console.Clear();
Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());
int[] Array(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1, 99);
    }
    return result;
}
int[] array = Array(size);
Console.WriteLine(String.Join("-", array));