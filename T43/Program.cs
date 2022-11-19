//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void IntersectionCoordin(int b1, int k1, int b2, int k2){
    if(k1 == k2 && b1 == b2) Console.Write("Линии совпадают");
    else if(k1 == k2) Console.Write("Линии параллельные, т.е. не пересекаются. ");
    else{
        double n = b2 - b1;
        double n1 = k1 - k2;
        double x = n / n1;
        double y = k1 * x + b1;
        Console.Write($" b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}  ->  ({x}; {y})");
    }
}
Console.Write("Введите значение b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());
IntersectionCoordin(b1, k1, b2, k2);