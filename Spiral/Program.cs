int[,] FillArray()
{
    int[,] array = new int[4, 4];
    int distance = array.GetLength(0) - 1;
    int count = 0;
    int value = 0;
    if(array.GetLength(0) == array.GetLength(1))
    {
        while(distance > 1)
        {
            for(int j = count; j < distance; j++)
            {
                value++;
                array[count, j] = value;
            }

            for(int i = count; i < distance; i++)
            {
                value++;
                array[i, distance] = value;
            }

            for(int j = distance; j > count; j--)
            {
                value++;
                array[distance, j] = value;
            }

            for(int i = distance; i > count; i--)
            {
                value++;
                array[i, count] = value;
            }

            distance -= 1;
            count += 1;

        }
    
        if(array.GetLength(1) % 2 > 0) array[(array.GetLength(0) - 1) / 2, (array.GetLength(1) - 1) / 2] = value + 1;
        return array;
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

int[,] array = FillArray();

ShowArray(array);