//  Вид 1 - метод который ничего не принимает и ничего не вовращает

// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }

// // Method1(); 



// // Вид 2  - метод который ничего не принимает и ничего не вовращает

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// //Method2(msg: "Текст сообщения");  // - вызов метода (идентификатор) 



// void Method21(string msg, int count)
// {
//     int i =0;
//     while (i <count)
//     {
//         Console.WriteLine(msg);
//         i++; // инкримент счетчика
//     }    
// }

//Method21(msg: "Текст сообщения",count: 4);  // - вызов метода (идентификатор) метод выводит текст 4 раза
//Method21(count: 4, msg: "Новый текст");  // - вызов метода (идентификатор) метод выводит текст 4 раза


// Вид 3 - метод который ничего не принимает но что-то вовращает

// int Method3()     //Если метод что-то возвращает, то нужно перед названием метода указывать Тип Данных
// {
//     return DateTime.Now.Year; // возврат резулата (DateTime.Now.Year) - проделанной работы метода  
// }

// int year = Method3(); // присвоим переменной year результат работы метода
//Console.WriteLine(year);



// Вид 4 - метод который что-то принимает и что-то вовращает

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // присвоим переменной result значение Пустой строки (String.Empty)

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z"); // Будем склеивать текс 10 раз
//Console.WriteLine(res);


// Вид 4 - метод который что-то принимает и что-то вовращает (только с циклом for)

// string Method4(int count, string text)
// {
    
//     string result = String.Empty; // присвоим переменной result значение Пустой строки (String.Empty)
//     for(int i = 0; i < count;i++) // синтаксис for ( int i = 0; - инициализация счетчика, i < count; - условие, i++ - инкримент)
//         {
//             result = result + text;
//         }
//     return result;
// }

// string res = Method4(10, "z"); // Будем склеивать текс 10 раз
// Console.WriteLine(res);


// //Задача. Вывод таблицы умножения на экран

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// Задача. 
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"                 // string массив с нашим текстом
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = “qwerty”
// // 012345
// //s[3] // r

// string Replace(string text, char oldValue, char newValue)    // метод поиска и замены символов в string массиве
// {
//     string result = String.Empty;                           // присваиваем переменной result значение Пустой строки

//     int length = text.Length;                               // присваиваем переменной length значение количества символов в строке
//     for (int i = 0; i < length; i++)                        // с помощью цикла for(int i = 0; i < length; i++) крутим каждый символ string массива
//         {
//             if(text[i] == oldValue) result = result + $"{newValue}"; // c помощью if & else проверяем совпадает ли символ  oldValue (старому символу)
//                                                                  // и если совпадает, то в значение result добавляем  newValue (новый символ), 
//             else result = result + $"{text[i]}";                // если не совпадает то в значение result добавляем проверяемый символ string массива
//         }

//     return result;
// }
// string newText = Replace(text, ' ', '|');   // вызов метода с условием замены в тексте всех пробелов на чёрточки
// Console.WriteLine(newText);                 // вывод получившегося текста
// Console.WriteLine();                        // вывод пустой строки

// newText = Replace(newText, 'к', 'К');       // вызов метода с условием замены в тексте
// Console.WriteLine(newText);                 // вывод получившегося текста
// Console.WriteLine();                        // вывод пустой строки

// newText = Replace(newText, 'С', 'с');       // вызов метода с условием замены в тексте
// Console.WriteLine(newText);                 // вывод получившегося текста
// Console.WriteLine();                        // вывод пустой строки


//                    Задача на упорядочивание массива
//                         Алгоритм решения задачи
//1. Найти позицию минимального элемента в неотсортитованной части массива
//2. Произвести обмен этого значения со значением первой неотсортитованной позиции
//3. Повторять пока есть неотсортитованные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};   // наш массив с числами

void PrintArray(int[] array)   // метод вывода массива на экран
{
    int count = array.Length;  // count равен длинне массива, в  данном случае 9
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)    // метод упорядочивания массива
{
    
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        // ищем минимальный элемент с помощью цикла в цикле
        for (int j = i + 1; j < array.Length; j++) // Если у нас j позиция начинается с i + 1 то на строке 161 нужно от array.Length отнять 1 (i < array.Length -1)
        {
            // ищем минимальный элемент с помощью if & else
            if (array[j] < array[minPosition]) minPosition = j; // если текущий элемент меньше того элемента 
            //который мы предполагали на минимальной позиции, то минимальной позиции присваиваем текущее значение j 
        }

        //обмен переменных местами
        int temporary = array[i];           // рабочия позиция i-тая позиция
        array[i] = array[minPosition];      // в i-тую позицию положем найденный элемент
        array[minPosition] = temporary;     // в минимальную позицию кладем временный элемент
    }

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);