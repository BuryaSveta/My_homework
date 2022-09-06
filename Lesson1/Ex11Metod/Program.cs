// Метод 1 
/*
void Metod1()
{
    Console.WriteLine("Автор Светлана Бурякова и хомячок Кексик и кошечка Маруся");
}
Metod1();
*/


// Метод 2 ВЫДАЕТ С ОШИБКОЙ!!!!
/*
void Metod2(message)
{
    Console.WriteLine(message);
}

Metod2 ("Текст сообщения");
*/
/*
void Metod21(string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }

}

//Metod21 (msg:"Текст", count: 4); либо
Metod21(count:4, msg: "New text");

*/

// Метод 3 С ОШИБКОЙ ВЫДАЕТ!!!!!
/*
int Metod3()
{
    return DataTime.Now.Year;
}
int year = Metod3;
Console.WriteLine(year);
*/

//Метод 4 С ОШИБКОЙ ВЫДАЕТ!!!!!
/*
string Metod4 (int count, string c);
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++; 
    } 
   
    return result;

}
string res = Metod4(10,"pizdec");
Console.WriteLine(res);
*/ 
// Метод 4 с другим циклом: ТОЖЕ С ОШИБКОЙ!!!!!!
/*
string Metod4 (int count, string text);
{
    string result = String.Empty;
    for ( int i = 0; i < count; i++)
    {
        result = result + text;
    } 
    return result;

}
string res = Metod4(10,"pizdec");
Console.WriteLine(res);
*/
// Задача. Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с". 
/*

string text = "- Я думаю, сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля."
            + "вы так красноречивы. Вы дадите мне чаю?";
            
//string s "qwerty"
//          012345
//s[3]//r
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[1]}";
    }

    return result;
}

string newText = Replace(text ,' ', '/');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text ,'к', 'К');
Console.WriteLine(newText);

//Получилась наполовину, текст не выводится!
*/

//Задача 2. Найти позициюминимального элемента в неотсортированной части массива.
// Произвести обмен этого значения со значением первой неотсортированной позициии.
// Повторять пока есть неотсортированные элементы.
/*
int [] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[]array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array [minPosition];
        array [minPosition] = temporary;
         
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/