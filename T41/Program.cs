//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}");
}
int SumPositiveNumber(int[] array){
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) count++;
    }
    return count;
}
int[] Fillarray(int size){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i]= Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.Write("Введите количество элементов в массиве:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите c клавиатуры {n} чисел  ");
int[] somearray = Fillarray(n);
PrintArray(somearray);  
Console.Write($" -> {SumPositiveNumber(somearray)}");