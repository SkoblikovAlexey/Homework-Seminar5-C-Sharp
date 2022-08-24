// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21

while (true)
{

    // Console.WriteLine("Введите пятизначное число");

    // int number = Convert.ToInt32(Console.ReadLine());


    // bool check(int num)
    // {
    //     string str = Convert.ToString(num);
    //     int length = str.Length - 1;
    //     bool result = true;
    //     for (int i = 0; i < length / 2; i++)
    //     {
    //         if (str[i] != str[length - i])
    //         {
    //             result = false;
    //             break;
    //         }
    //         else
    //         {
    //             result = true;
    //         }
    //     }
    //     return result;
    // }
    int[] CreateArray(int N)
    {
        int[] arr = new int[N];
        Console.WriteLine($"Введите {N} элементов массива");
        for (int i = 0; i < N; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
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

    int[] NewArray(int[] arr)
    {
        int len = arr.Length / 2;

        if (arr.Length % 2 == 1) len++;
        int[] newArray = new int[len];
        for (int i = 0; i < arr.Length / 2; i++)
        {
            newArray[i] = arr[i] * arr[(arr.Length - 1) - i];
        }
        if (arr.Length % 2 == 1) newArray[len - 1] = arr[arr.Length / 2];
        return newArray;
    }

    Console.WriteLine("Введите число, равное количеству элементов в массиве");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(N);
    PrintArray(array);
    PrintArray(NewArray(array));
    Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}