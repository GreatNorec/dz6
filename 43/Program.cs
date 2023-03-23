//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 => 2
//1, -7, 567, 89, 223 => 4

Console.Write("Введите какое-то кол-во чисел через запятую: ");
string array = Console.ReadLine().Replace(",", "");

int[] arr = Array.ConvertAll( array.Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Кол-во элементов больше 0: {count}");