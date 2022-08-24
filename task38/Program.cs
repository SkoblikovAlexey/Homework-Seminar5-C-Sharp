// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

while (true)
{
    int[] CreateArray(int N)
    {
        int[] array = new int[N];
        Console.WriteLine($"Введите {N} элементов массива.");
        for (int i = 0; i < N; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    }
    void PrintArray(int[] arr)
    {
        int length = arr.Length;
        Console.Write("[");
        for (int i = 0; i < length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[length - 1] + "]");
    }

    int CalcMaxMinDiff(int[] arr)
    {
        int max = arr[0];
        int min = arr[0];
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
            result = max - min;
        }
        return result;
    }

    Console.WriteLine("Введите количество элементов массива.");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(N);
    PrintArray(array);
    Console.WriteLine($"Разница между max и min элементами массива равна {CalcMaxMinDiff(array)}.");

    Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}