// ищем максимум из 9 часел c помощью функции и массива

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// определяем массив 
//с индексами    0    1    2    3    4    5    6    7    8
int[] array = { 141, 232, 353, 425, 541, 136, 147, 585, 169 };

// присовение значения нулевому элементу массива: array[0]= 12;

// выдача пятого элемента массива: Console.WriteLine(array[5]);

int result = Max(
   Max(array[0], array[1], array[2]),
   Max(array[3], array[4], array[5]),
   Max(array[6], array[7], array[8]));

Console.WriteLine($"MAX = {result}");
