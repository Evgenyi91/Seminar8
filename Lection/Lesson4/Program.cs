int[] array = {1, 2, 4, 3, 5, 6, 7, 8, 9, 6};
int n = array.Length;
int find = 9;
// int index = 0;
// while(index < n)
// {
//     if(array[index] == find)
//     {
//         System.Console.WriteLine(index);
//         // break;
//     }
//     index++;
// }
for(int index = 0; index < n; index++)
{
    if(array[index] == find)
    // break;
    System.Console.WriteLine(index);
}