// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.


Main();

void Main()
{
  Console.WriteLine("Введите количество элементов в массиве:");
  int s;
  if (int.TryParse(Console.ReadLine(), out s) && s > 0)
  {
     int num = s;
  }
  else Console.WriteLine("This is not a number! Try again!");
  string [] str = new string[s];
  
}