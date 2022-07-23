int[,] FillArray()
{
    int[,] array = new int[3, 4];
    for(int i = 0; i < 3; i++)
        for(int j = 0; j < 4; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

int[,] RowsSort(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
        {
        
        for(int count = 0; count < array.GetLength(1) - 1; count++)
            {
                int b = array.GetLength(1) - 1;
                for(int j = 0; j < b; j++)
                {
                    if(array[i, j] > array[i, j + 1])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, j + 1];
                        array[i, j + 1] = temp;
                    }   
                }
                b--;
            }
        }    
    return array;
}

int[,] array = FillArray();

ShowArray(array);

Console.WriteLine();

array = RowsSort(array);

ShowArray(array);

