namespace C_Practice_modul_09_part_02_ua
{

    public delegate bool CheckEvenDelegate(int num);
    public delegate int CalcSquareDelegate(int num);
    public delegate int CalcCubeDelegate(int num);
    public delegate bool CheckProgrammersDayDelegate(int dayOfYear);
    public delegate int FindMaxDelegate(int[] arr);
    public delegate int FindMinDelegate(int[] arr);
    public delegate int[] FindOddnumsDelegate(int[] arr);
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckEvenDelegate checkEven = delegate (int num)
            {
                return num % 2 == 0;
            };
            Console.WriteLine(checkEven(4)); 
            Console.WriteLine(checkEven(7)); 

          
            CalcSquareDelegate CalcSquare = delegate (int num)
            {
                return num * num;
            };
            Console.WriteLine(CalcSquare(5)); 
            Console.WriteLine(CalcSquare(9)); 

           
            CalcCubeDelegate CalcCube = (num) =>
            {
                return num * num * num;
            };
            Console.WriteLine(CalcCube(3)); 
            Console.WriteLine(CalcCube(4));

            CheckProgrammersDayDelegate checkProgrammersDay = (dayOfYear) =>
            {
                return dayOfYear == 256;
            };
            Console.WriteLine(checkProgrammersDay(256)); 
            Console.WriteLine(checkProgrammersDay(100)); 

           
            FindMaxDelegate findMax = (arr) =>
            {
                return arr.Max();
            };
            int[] nums1 = { 1, 3, 5, 7, 9 };
            Console.WriteLine(findMax(nums1)); 

            
            FindMinDelegate findMin = (arr) =>
            {
                return arr.Min();
            };
            int[] nums2 = { 2, 4, 6, 8, 10 };
            Console.WriteLine(findMin(nums2)); 

            
            FindOddnumsDelegate findOddnums = (arr) =>
            {
                return arr.Where(x => x % 2 != 0).ToArray();
            };
            int[] nums3 = { 1, 2, 3, 4, 5 };
            int[] oddnums = findOddnums(nums3);
            Console.WriteLine(string.Join(", ", oddnums)); 
        }
    }
}
