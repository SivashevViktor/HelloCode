int[] array = { 19, 22, 38, 88, 54, 56, 61, 47, 88 };

int n = array.Length;
int find = 88;

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
