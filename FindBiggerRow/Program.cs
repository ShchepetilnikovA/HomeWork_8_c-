
        int[,] FillArray()
        {
            int[,] array = new int[3, 4];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = new Random().Next(1, 10);
                }
            return array;
        }

        void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }

        void FindLowestRow(int[,] array)
        {
            int[] arrayOfSum = new int[array.GetLength(0)];
            for (int i = 0; i < 3; i++)
            {
                int sumRow = 0;
                for (int j = 0; j < 4; j++)
                {
                    sumRow += array[i, j];

                }
                arrayOfSum[i] = sumRow;
            }

            int indexOfMin = 0;
            int min = arrayOfSum[0];

            for (int k = 0; k < arrayOfSum.Length - 1; k++)
            {

                if (min > arrayOfSum[k + 1])
                {
                    min = arrayOfSum[k + 1];
                    indexOfMin = k + 1;
                }
            }

            Console.WriteLine("Row with min sum of elements is: " + (indexOfMin + 1));
        }

        int[,] array = FillArray();

        ShowArray(array);

        Console.WriteLine();

        FindLowestRow(array);
