class Program
{
    static void Main()
    {
        int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};
        array = [2,3,4,5,6,7,8,9,10,11];
        array[0] = 1;
        array[1] = 2;
        System.Console.WriteLine(array[4]);

        int[] array2 = [0,1,..array];

        System.Console.WriteLine(array2[^1]);
        //int[] array3 = [1..10]

        int[,] matrix = new int[2,3] {{1,2,3}, {4,5,6}};
        System.Console.WriteLine(matrix[0,1]);
        
        array[9] = 12;

        int[][] jagged = new int[5][];
        jagged[0] = [1,2,3];
        jagged[1] = [1,2,3,4,5,6,7];

        
        Stack<int> stack = new Stack<int>();
        stack.Push(6);

        List<int> list = new List<int>();
        list.Add(1);
        list.AddRange(array);

        for(int i = 0; i < array.Length; i++)
        {
            int tmp = array[i];
            System.Console.WriteLine(tmp);
        }

        foreach(int tmp in array)
        {
            System.Console.WriteLine(tmp);
        }

        Dictionary<string, int> dict = new();
        dict.Add("een", 1);
        dict.Add("twee", 2);


        System.Console.WriteLine(dict["twee"]);
        //dict.tr
    }
}
