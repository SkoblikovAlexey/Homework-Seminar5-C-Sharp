// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

while (true)
{
    int[] CreateArray(int N)
    {
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = new Random().Next(-100, 100);
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

    int SummOddNumbers(int[] arr)
    {
        int summ = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 1)
            {
                summ += arr[i];
            }
        }
        return summ;
    }

    Console.WriteLine("Введите количество элементов массива.");
    int N = Convert.ToInt32(Console.ReadLine());

    int[] array = CreateArray(N);
    PrintArray(array);
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {SummOddNumbers(array)}");

    Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}