//Вид 1
void Method1()
{
    Console.WriteLine ("Автор...");
}
//Method1();

//Вид2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения"); //можно без msg

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(count: 4, msg: "Текст"); //можно без msg и count, но это позволяет их писать не в изначальном порядке (например, сначала count, а потом msg)

//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine (year);

//Вид 4
/*string Method4(int count, string text) //с циклом while
{
    int i = 0;
    string result = String.Empty;//пустая строка, можно просто ""
    while (i < count)
    {
       result = result + text;
        i++;
    }
    return result;
}

{
    int i = 0;
    string result = String.Empty;//пустая строка, можно просто ""
    while (i < count)
    {
       result = result + text;
        i++;
    }
    return result;
}*/
string Method4(int count, string text)//с циклом for
{
    string result = String.Empty;//пустая строка, можно просто ""
    for(int i = 0; i < count; i++)
    {
       result = result + text;
    }
    return result;
}
string res = Method4 (10, "z");
//Console.WriteLine(res);
/* //таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();//делаем отступ для нового числа
}
*/

/*
Работа с текстом
Дан текст. В тексте нужно все пробелы заменить чёрточками,
Маленькие буквы к заменить большими К,
Большие С - маленькими С
*/
/*string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
//string s = "qwerty"
//            012345
//       s[3] // r
string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}

string newText = Replace (text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace (newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace (newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();
*/

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort (int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)// -1 потому что ниже i+1
    {
        int minPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    Console.WriteLine();
}
PrintArray (arr);
SelectionSort (arr);

PrintArray (arr);