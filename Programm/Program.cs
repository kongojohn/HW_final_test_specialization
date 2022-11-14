// Программа из введенного массива строк формирует массив строк, длина которого меньше либо равна 3 символам.
#nullable disable

Console.Write("Введите к-во элементов массива (не больше 10): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 10)
{
    Console.WriteLine("К-во элементов массива должно быть меньше или равно 10! Программа завершает работу!");
    return;
}

string[] array = new string[n];
string[] resaultArray = new string[n];

FillArray(array);
Console.Write("Введенный массив: ");
ShowArray(array);
Array.Resize(ref resaultArray, ArrayCheck(array, resaultArray));
Console.Write("Результирующий массив: ");
ShowArray(resaultArray);


void FillArray(string[] fillableArray)
{
    for (int i = 0; i < fillableArray.Length; i++)
    {
        Console.WriteLine("Введите значение в виде строки " + (i + 1) + "-го элемента массива:");
        fillableArray[i] = Console.ReadLine();
    }
}

int ArrayCheck(string[] filledArray, string[] resaultArray)
{
    int count = 0;
    for (int i = 0; i < filledArray.Length; i++)
    {
        if (filledArray[i].Length <= 3)
        {
            resaultArray[count] = filledArray[i];
            count++;
        }
    }
    return (count);
}

void ShowArray(string[] displayedArray)
{
    Console.WriteLine($"[{String.Join("; ", displayedArray)}]");
}