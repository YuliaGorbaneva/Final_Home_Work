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
    FillString(str);
    PrintString(str);
    Console.WriteLine();
    MinString(str);
}

void FillString(string [] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        str [i] = Console.ReadLine();
        if(str[i] == "")
            {
                i--;
            }
    }
}

void PrintString(string [] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write("{0} ", str[i]);
    }
}

string [] MinString(string [] str)
{
    string [] massiv = new string[str.Length];
    int min = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            massiv [min] = str[i];
            min++;
        }
    }
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]} ");
        
    }
    return str;
}
