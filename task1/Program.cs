// **Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].

// *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0

while (true)
{
    
int[] CreateArray(int num)
{
    int[] arr = new int[num];
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(0, 200);                        
    }
    return arr;
}

int SortArray(int[] array)
{
    int len = array.Length;
    int result = 0;
    int a = 10;
    int b = 99;
    for (int i = 0; i < len; i++)
    {
    
        if (array[i] >= a && array[i] <= b)
        {
            result = result + 1;
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
Console.WriteLine(array[array.Length - 1] + "]");
}
Console.WriteLine("Введите число элементов массива.");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(num);

PrintArray(array);
Console.WriteLine();
Console.WriteLine(SortArray(array));
Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}