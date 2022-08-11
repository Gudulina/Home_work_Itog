/* Написать программу, которая из массива строк
формирует массив строк, длина которых меньше либо равна 3 символа. */

string[] arrayFirst = new string[4] {"hello", "2", "world", ":-)"};
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

