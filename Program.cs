/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 9999);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length)
        {
            System.Console.Write("  ");
        }
    }

}

int[] CorrArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] / 1000 == 0)
        {
            System.Console.Write($"{array[i]}   ");
        }
    }
    return array;
}

System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] userArr = GetArray(size);
PrintArray(userArr);

System.Console.WriteLine();
System.Console.WriteLine();

CorrArr(userArr);