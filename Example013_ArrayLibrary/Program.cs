void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int InedxOf(int[] collection, int find)
{
int count = collection.Length;
int index = 0;
int position = 0;
while (index < count)
{
    if(collection[index] == find)
    {
        position = index;
        break;
    }
    index++;
}
return position;
}

int[] array = new int[10]; //создаем новый массив arry с 10 элеменами 

FillArray(array); // метод заполнения массива
PrintArray(array); // метод печати массива на экран
Console.WriteLine();

int pos = InedxOf(array, 9);
Console.WriteLine(pos);