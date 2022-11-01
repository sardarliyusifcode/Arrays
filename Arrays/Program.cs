#region Task 1
//int[] array = { -45, 6, 89, -4, 5, -16 };
//int minimumElement = array[0];
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] < minimumElement)
//    {
//        minimumElement = array[i];
//    }
//}
//Console.WriteLine(minimumElement);
#endregion

#region Task 2

int[] array = { 454, 9, 6, 89, 5, };
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >=0 && array[i] <= 9)
    {
        sum++;
    }
}
Console.WriteLine(sum);
#endregion