int[,,] array = new int[2,2,2];
// Random rnd = new Random();
FillArray(array);
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.WriteLine();
       for (int k = 0; k < array.GetLength(2); k++)
       {
        // array[i,j,k] = rnd.Next(10, 99);
       System.Console.Write($"{array[i,j,k]} ({i}{j}{k}) ");
       } 
    }
}    
void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}


