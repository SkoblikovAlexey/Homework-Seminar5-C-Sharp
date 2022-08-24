// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


while (true)
{
int[] CreateArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
Console.WriteLine("Введите количество элементов массива.");
int N = Convert.ToInt32(Console.ReadLine());

int CountEvenNumbers(int[] arr) {
    int result = 0;
    for(int i =0; i < arr.Length; i++){
        if(arr[i] % 2 == 0) result++;
    }
    return result;
}

int[] array = CreateArray(N);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве равно {CountEvenNumbers(array)}");
Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}