int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // если выполнилось условие то прервать
    }
//  index = index + 1 - счетчик, но прравильнее index++, поэтому
index++;
}