int[] array = { 13, 452, 345, 68, 19, 345, 0, 41, 385, 70, 345, 4 };
int n = array.Length;
int find = 345;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}