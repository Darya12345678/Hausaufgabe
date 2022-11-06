string[] array1 = new string[4] {"1", "int", "10", "print"};
string[] array2 = new string[array1.Length];
int x = 2;
int y = 0;
void CopyToSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(count <= 1)
        {
        int num = new Random().Next(y,x);
        array2[count] = array1[num];
        count++;
        x = 4;
        y = 2;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
CopyToSecondArray(array1, array2);
PrintArray(array2);