namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region test
            #region
            //int[] arr = { 1, 3, 5, 7, 9 };
            //int min = arr[0], max = arr[0], sum = 0;
            //for (int i = 0; i < arr.Length ; i++) {
            //    if (arr[i] >  max) 
            //        max = arr[i];
            //    if(arr[i] < min)
            //        min = arr[i];

            //}
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            //int minsum = 0;
            //int maxsum = 0;
            //for (int i = 0; i < arr.Length; i++) {
            //    minsum += arr[i];
            //    maxsum += arr[i];
            //}
            //Console.WriteLine(minsum - max);
            //Console.WriteLine(maxsum - min);
            //foreach (int i in arr) {
            //    if (i > max)
            //        max = i;
            //    if (i < min)
            //        min = i;
            //    sum+= i;
            //}
            //Console.WriteLine(sum - max);
            //Console.WriteLine(sum - min);
            #endregion
            #region
            //Console.WriteLine(" enter a number to reverse it");
            //int number = int.Parse(Console.ReadLine());
            //string s = number.ToString();
            //char[] cahrarr = s.ToCharArray();
            //System.Array.Reverse(cahrarr);
            //if (cahrarr[0] == '0')
            //{
            //    cahrarr = Array.FindAll(cahrarr, val => val != '0');
            //    Console.WriteLine(string.Join("", cahrarr));
            //}
            //else {
            //    Console.WriteLine(string.Join("", cahrarr));

            //}

            //Console.WriteLine("Enter a number to reverse it:");
            //int number = int.Parse(Console.ReadLine());

            //// Handle negative numbers
            //bool isNegative = number < 0;
            //string reversedStr = new string(Math.Abs(number).ToString().Reverse().ToArray());

            //// Convert back to int to remove leading zeros
            //int reversedNumber = int.Parse(reversedStr);

            //// Print with the original sign
            //Console.WriteLine(isNegative ? -reversedNumber : reversedNumber);
            #endregion
            #region
            /////////////////////////////////////////////
            ///
            /// 
            /// 
            ////////Median of Two Sorted Arrays
            //    int[] arr1 = { 1, 3 };
            //    int[] arr2 = {2 };
            //    List<int> list = new List<int>(arr1);
            //   list.AddRange(arr2);
            //    list.Sort();
            //    int[] result = list.ToArray();
            //    //foreach (int i in result) { Console.WriteLine(i); }
            //    double median = 0;
            //    if (result.Length % 2 == 0)
            //    {
            //        int index = result.Length / 2;
            //        median = (result[index] + result[index - 1]) / 2.0;
            //    }
            //    else {
            //        int index = result.Length  / 2;
            //        median = result[index];

            //    }
            //    Console.WriteLine(median);
            #endregion
            #region
            //Console.WriteLine(fun([2,7,11,15] , 9));
            //int[] arr1 = [2, 4, 3];
            //int[] arr2 = [5, 6, 4];
            //char[] arr3 = arr1.Select(d => (char)(d + '0')).ToArray();
            //char[] arr4 = arr2.Select(d => (char)(d + '0')).ToArray();
            //int num1 = int.Parse(arr3);
            //int num2 = int.Parse(arr4);
            //int sum = num1 + num2;
            //    string s = sum.ToString();
            //List<char> list = new List<char>(s);
            //list.Reverse();
            #endregion
            /////////////////////////////////////////////////////////////////////////

            //Console.WriteLine(HasSpecialSubstring("jkjhfgg", 2));
            //Console.WriteLine(SearchInsert([1] ,2));
            //    string[] LongestCommonPrefix = ["flower", "flow", "flight"];
            //    Array.Sort(LongestCommonPrefix);
            //    string first = LongestCommonPrefix[0];
            //    string last = LongestCommonPrefix[LongestCommonPrefix.Length - 1];
            //    int i = 0;
            //    string s = "";
            //while(i < first.Length && i<last.Length && first[i] == last[i])
            //    {
            //        i++;
            //    }
            //s= first.Substring(0,i);
            //    Console.WriteLine(s);
            ///////////////////////////////////////
            ///
            //Console.WriteLine(Math.Pow(2.00000,10));
            //double n = Math.Pow(2.0000, 10);
            //Console.WriteLine(n);
            //Console.WriteLine();
            ////////////////////////////////////////////////
            //Console.WriteLine(IsPrime(4));
            //Console.WriteLine(IsPrime(6));
            //Console.WriteLine(IsPrime(8));
            //Console.WriteLine(IsPrime(9));
            //Console.WriteLine(IsPrime(75));
            //Console.WriteLine(IsPrime(7));
            //Console.WriteLine(IsPrime(27513));
            
            





   
            #endregion

        }

        //static bool HasSpecialSubstring(string s ,  int k)
        //{

        //  int count = 0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int j = 0; j < s.Length; j++)
        //        {
        //            if (s[i] == s[j])
        //                count++;
        //            else {
        //                if (k == count)
        //                    return true;
        //            }


        //        }



        //    }
        //    if (k == count) return true;
        //    else { return false; }


        //}
        //static int[] fun(int[] arr, int target)
        //{
        //    int[] sum = {0}; 
        //    for (int i = 0; i < arr.Length -1; i++)
        //    {
        //        for(int j = 0; j < arr.Length; j++) {
        //            if (arr[i] + arr[j] == target)
        //            {

        //                sum = [i,j];

        //            }
        //        }

        //    }
        //    int[]a = (int[])sum.Clone();
        //    return a;

        //}
        //static int SearchInsert(int[] nums, int target)
        //{
        //    int s = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] == target)
        //        {
        //            s = i;
        //            break;
        //        }
        //        else
        //        {
        //            for (int j = i + 1; j < nums.Length; j++)
        //            {
        //                if (nums[j] > target && nums[i] < target)
        //                {
        //                    s = j;
        //                    break;
        //                }

        //                else if (target >= nums[i])
        //                    s = nums.Length;
        //                else if (nums.Length == 1 && target > nums[i])
        //                { s = i+1; }

        //            }
        //        }
        //    }
        //    return s;
        //            int s = 0;
        //            int min = 0;
        //            int max = nums.Length-1;
        //            while (min <= max) {
        //                int mid = min + (max - min) / 2;
        //                if (nums[mid] <= target)
        //                {
        //                    s = mid;
        //                    break;
        //                }
        //                else if (nums[mid] < target)
        //                {
        //                    min = mid + 1;
        //                }
        //                else {
        //                    max = mid - 1;
        //                }

        //}
        //            return s;}
        //public static bool IsPrime(int n)
        //{
        //    bool s = true;
        //    for (int i = 2; i*i <= n; i++)
        //    {
        //        if (n % i == 0)
        //            s = false;
                
              


        //    }
        //    return s;
        //}


    }
}

