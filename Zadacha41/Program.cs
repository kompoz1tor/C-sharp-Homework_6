/*

Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/
Console.WriteLine("Введите количество символов в массиве:");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
Console.WriteLine("Заполните массив символами, через ENTER");


void fillArray(int[] A)
{
    for (int i = 0; i < M; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
}
 
void currnetNumber(int[] A)
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Чисел больше 0 в массиве: {count}");
}


fillArray(array);
currnetNumber(array);