// //Вид 1 ничего не принимают и ничего не выдают
// using System.Reflection.Metadata;

// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

// //Вид 2 Ничего не возвращают, но принимают какие-то аргументы
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения"); //или Method2(msg: "Текст сообщения"); 

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст", 4); //или Method21(msg: "Текст", count: 4);

// //Вид 3 Что-то возвращают, но ничего не принимают
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

//Вид 4 Что-то возвращают, и что-то принимают
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4 (10, "asdf");
// Console.WriteLine(res);

//  string Method4(int count, string text)
//  {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
//  }

// string res = Method4(10, "z");
// Console.WriteLine(res);

// for (int i = 2; i<=10; i++)
// {
//     for(int j=2; j<=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

//Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с"

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//            012
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty; //Инициализация пустой строки

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result += $"{newValue}";
//         else result += $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace (text, ' ', '|');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace (text, 'к', 'К');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace (text, 'С', 'с');
// Console.WriteLine(newText);

using System.ComponentModel.DataAnnotations;

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)  //ищем минимальное значение
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i]; //меняем значение нашей минимальной позиции с той позицией которую нашли
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray (arr);
SelectionSort(arr);
PrintArray(arr);
