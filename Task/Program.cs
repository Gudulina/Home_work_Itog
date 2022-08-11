/* Написать программу, которая из массива строк
формирует массив строк, длина которых меньше либо равна 3 символа. */

string[] arrayFirst = new string[4] {"hello", "2", "world", ":-)"};
//string[] arrayFirst = new string[4] {"1234", "1567", "-2", "computer science"};

string[] arraySecond = new string[arrayFirst.Length];

void ArrayFormation (string[] arrayFirst, string[] arraySecond)
{
    int j = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        if (arrayFirst[i].Length <=3)
        {
            arraySecond[j] = arrayFirst[i];
            j++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"{array[i]} ");
        }
    Console.WriteLine();
}

ArrayFormation (arrayFirst, arraySecond);
PrintArray (arraySecond);
