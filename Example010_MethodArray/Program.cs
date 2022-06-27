int[] array = { 11, 22, 53, 14, 18, 51, 16, 17, 18 };
int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // прерываем искать дальше
    }
    //index=index+1;    
    index++;
}