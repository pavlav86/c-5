/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void ShowDif(double[] arr)
{
  Console.Write("[" + string.Join("; ", arr) + "] -> " + GetDif(arr));
}

double GetDif(double[] arr)
{
  double min, max;
  min = max = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < min) min = arr[i];
    else if (arr[i] > max) max = arr[i];
  }

  return Math.Round(max - min, 2);
}

double[] GenerateArray(int size)
{
  double[] arr = new double[size];
  for(int i = 0; i < size; i++)
  {
    arr[i] = Math.Round(new Random().NextDouble() * 100, 2);
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
double[] array = GenerateArray(number);
ShowDif(array);
