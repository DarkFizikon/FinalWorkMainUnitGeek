string[] CreateStringArray() //Ввод строк(количество и сами строки)
{
    Console.Write("Введите количество строк: ");
    int countstr = Convert.ToInt32(Console.ReadLine());

    string[] stringarray = new string[countstr];
    for (int i = 0; i < stringarray.Length; i++)
    {
        Console.Write($"Введите строку {i + 1}: ");
        stringarray[i] = Console.ReadLine();
    }
    return stringarray;
}

void PrintStringArray(string[] arraystring) //Вывод введенных строк в виде массива
{
    Console.Write("[");
    for (int i = 0; i < arraystring.Length; i++)
    {
        if (i == arraystring.Length - 1)
        {
            Console.Write(arraystring[i]);
        }
        else
        {
            Console.Write($"{arraystring[i]}, ");
        }
    }
    Console.WriteLine("]");
}

int FindNewSize(string[] strfornewsize) //Определение количества строк из трех символов
{
    int count = 0;
    for (int i = 0; i < strfornewsize.Length; i++)
    {
        if (strfornewsize[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] FindShortString(string[] strforsearch, int c) //Поиск в массиве из строк строку с 3 символами
{
    string[] newstr = new string[c];
    int j = 0;
    for (int i = 0; i < strforsearch.Length; i++)
    {
        if (strforsearch[i].Length <= 3)
        {
            newstr[j] = strforsearch[i];
            j++;
        }
    }
    return newstr;
}
string[] strarr = CreateStringArray();
Console.Write("Введенные строки: ");
PrintStringArray(strarr);
int newsize = FindNewSize(strarr);
string[] printstr = FindShortString(strarr, newsize);
Console.Write("Строки в которых меньше 3-х символов: ");
PrintStringArray(printstr);