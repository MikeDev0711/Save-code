     static int Pow(int x, int y=2)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
                Console.WriteLine(result);
            }
 
            return result;
        }