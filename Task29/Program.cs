// Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] 
//и выводит на экран .
//5 -> [1, 2, 5, 7, 19]
//3 -> [6, 1, 33]

Random rand = new Random();
Console.Write ("Введите длину массива: ");
int lenghtOfArray = Convert.ToInt32(Console.ReadLine());

Console.Write($"Полученный массив из {lenghtOfArray} элемента(ов): [");

int[] array = new int[lenghtOfArray];
for(int i = 0; i < lenghtOfArray; i++)
{
      array[i] = rand.Next(1, 99);
      Console.Write($"{array[i]}");
      if (i < lenghtOfArray-1)
      {
        Console.Write(", ");
      }
}
Console.WriteLine("]");