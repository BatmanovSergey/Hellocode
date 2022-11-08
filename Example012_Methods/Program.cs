// Вид 1 - ничего не принимают и ничего не возвращают

void Method1() // в скобочках никаких аргументов нет, так как метод ничего не принимает
{
    Console.WriteLine("Автор: Сергей - Method1"); // например надо что-то выводить на печать
    Console.WriteLine();
}

Method1(); // Вызов void метода1


// Вид 2 - принимают какие-то аргументы, но ничего не возвращают

void Method2(string msg) // метод принимает аргумент строка с текстом string msg
{
    Console.WriteLine(msg); // выводим на печать наш аргумент
    Console.WriteLine(); // выводим на печать пустую строку
}
Method2("Текст сообщения - Method2"); // Вызов void метода2, в качестве аргумента 
                                      //передаем "Текст сообщения" в кавычках

// также могут быть именованнаые аргументы, когда у нас явно может быть указано, 
// какому аргументы, какое значение мы хотим указать используется конструкция  с двоеточием : например msg:
// это бывает часто нужно, когда метод принимает какое-то количество аргументов, отличное от одного
Method2(msg: "Текст сообщения - Method2 с явным аргументом");

void Method21(string msg, int count) // метод принимает аргумент строка с текстом string msg 
// и какое-то целое число int переменной count, которое показывает сколько раз мы хотим вывести на экран
// сообщение msg, которые мы будем непосредственно передавать в наш метод
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg); // выводить наше сообщение, пока i < count
        i++; // инкремент
    }
    Console.WriteLine();
}

// Вызов нашего метода21 указываем текст и через запятую, сколько раз мы хотим уувидеть данный текст
Method21("Тест - Method21 - выводим четыре раза", 4);

// теперь явно укажем какому аргументу какое значение мы хотим присвоить
// через использование конструкции msg:"...", count: число
Method21(msg: "Тест - Method21 с явным аргуменом - выводим пять раз", count: 5);

// именнованные аргументы необязательно писать по порядку
Method21(count: 3, msg: "Тест - Method21 с явным аргуменом не попорядку - выводим три раза");


// Вид 3 - ничего не принимают и что-то возвращают
// Если метод что-то вовзращает, то в обязательном порядке надо указать тип данных, которые он вовзвращает
// обязательно использование оператора return

int Method3()
{
    return (DateTime.Now.Year);
}

int year = Method3(); // вызов нашего метода, переменной date присваиваем значение, ктороые вернёт наш метод3
Console.WriteLine($"Текущий год {year} - Method3");
Console.WriteLine();

// Вид 4 - принимают какие-то аргументы и что-то возвращают
// строку string c будем друг за дружкой компановать count раз
string Method4(int count, string text)
{
    int i = 0;
    //string result = ""; // в начале в переменную result кладём пустую строку
    string result = string.Empty; // тоже самое что выше, но более правильно
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "Z ");
Console.WriteLine($"{res} - Method4");
Console.WriteLine();

string Method41(int count, string text)
{
    //string result = ""; // в начале в переменную result кладём пустую строку
    string result = string.Empty; // тоже самое что выше, но более правильно
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res1 = Method41(10, "Z ");
Console.WriteLine($"{res1} - Method41 цикл for");
Console.WriteLine();

// Таблица умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}


// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками.
// Маленькие буквы "к" заменить на большие "К",
// а большие буквы "c" заменить маленькими "C".

// Ясна ли задача?

string text = "– Я думаю, – сказал князь, улыбаясь, – что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// обращение к конкретной букве в строке
// string s = "qwerty"
//             012345
// s[3] будет буква r
//             строка       символ         символ
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // инициализация пустой строки

    int lenght = text.Length; // получаем длину строки (количество символов в ней)
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
//                   строка       символ char выделяется таким вот образом' '
string newText = Replace(text, ' ', '|');
Console.WriteLine(text);
Console.WriteLine();

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();

// Сортировка массива по возврастанию элементов
//            0  1  2  3  4  5  6  7  8      индексы элементов
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array) // void метод вывода массива на печать
{
    int count = array.Length; // задаем считчик на длину массива
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // void метод сортировки нашего массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i; // запоминаем позицию рабочего элемента
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);