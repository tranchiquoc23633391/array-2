public class Program
{
    public static void Main(string[] args)
    {

        // int[,] array = {
        //     {1,2,3,4},
        //     {6,7,8,9},
        //     {3,2,1,0}
        // };

        int[,] array = new int[3, 3];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }



        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }

        // tim gia tri lon nnhat
        int max = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
        }

        Console.WriteLine("max is: " + max);
    }
}