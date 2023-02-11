void DakArray(int[] raw)
{
    // int n = raw.Length;
    // int i = 0;
    // while(i < n)
    // {
    //     raw[i] = new Random().Next(10);
    //     i++;
    // }
    for (int i = 0; i < raw.Length; i++)
    {
        raw[i] = new Random().Next(10);
        System.Console.WriteLine(raw[i]);
    }
}

// void DokArray(int[] row)
// {
//     // int m = row.Length;
//     // int j = 0;
//     // while(j < m)
//     // {
//     //     System.Console.WriteLine(row[j]);
//     //     j++;
//     // }
//     for (int j = 0; j < row.Length; j++)
//     {
//         System.Console.WriteLine(row[j]);
//     }
// }
int Bugaa(int[] law, int find)
{
    // int k = law.Length;
    // int i = 0;
    int index = 0;
    // while(i < law.Length)
    // {
    //     if(law[i] == find)
    //     {
    //         index = i;
    //         // break;
    //     }
    //     i++;
    // }
    for (int i = 0; i < law.Length; i++)
    {
         if(law[i] == find)
        {
            index = i;
            // break;
        }
    }
    return index; 
}


int[] array = new int[10];

DakArray(array);
// DokArray(array);
System.Console.WriteLine();

int ind = Bugaa(array, 4);
System.Console.WriteLine(ind);