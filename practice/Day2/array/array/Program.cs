class array1
{
    int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

    public void show()
    {
        Console.Write("Output of the array is: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            Console.Write(" ");
        }
    }

    public static void Main()
    {
        array1 obj = new array1();
        obj.show();
    }
}
