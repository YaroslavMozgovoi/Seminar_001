
int[] array = { 21, 32, 33, 44, 5, 64, 7, 85, 9, };
int n = array.Length;
int find = 64;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}