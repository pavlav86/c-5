/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void ShowSum(int[] arr)
{
  Console.Write("[" + string.Join(", ", arr) + "] -> " + CalculateSum(arr));
}

int CalculateSum(int[] arr)
{
  int sum = 0;
  for (int i = 1; i < arr.Length; i += 2)
  {
      sum += arr[i];
  }
  return sum;
}

int[] GenerateArray(int size, int from, int to)
{
  int[] arr = new int[size];
  for(int i = 0; i < size; i++)
  {
    arr[i] = new Random().Next(from, to + 1);
  }
  return arr;
}

int GetLength(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int number = GetLength("Введите длину массива: ");
int[] array = GenerateArray(number, 0, 10);
ShowSum(array);
