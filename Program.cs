namespace Train2
{

    internal class Program
    {
        delegate int calcDelgetint (int x, int y);
        delegate string calcDelgetstring(string x, string y);

        //public class em
        //{
        //    public string name { get; set; }
        //    public int basicsalary { get; set; }
        //    public int Deduc { get; set; }
        //    public int bonus { get; set; }
        //}
        static void Main(string[] args)
        {

            #region Day 1 ITI
            // Problem 1 
            //int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

            //int max = 0;
            //for (int i = 0; i < arr.Length-1; i++) {
            //    int count = 0;
            //    for (int j = 0; j < arr.Length; j++) {
            //        while (arr[i]!= arr[j])
            //        {
            //            count++;

            //        }
            //    }
            //    if (count > max)
            //    {
            //        max = count;
            //        //count++;
            //    }
            //}
            //Console.WriteLine(max);
            ///////////////////////
            ///
            // Problem 2 
            //Console.WriteLine("' enter a string' ");
            //string str = Console.ReadLine();
            //string[] arr = str.Split(' ');
            //System.Array.Reverse(arr);
            //string m = string.Join(" ", arr);
            //Console.WriteLine(m);
            //string []   str2 = str.Split(new char[] { ' ' });
            //   str2 = str2.Reverse().ToArray();
            //   str2.ToString();

            ///////////////////////////////////////////
            ///Problem3
            ///
            //Console.WriteLine(" enter a number ");
            //long number = int.Parse(Console.ReadLine());
            //long count = 0;

            //for (long i = 0; i <= number; i++)
            //{
            //    string n = i.ToString();
            //    for (int j = 0; j < n.Length; j++)
            //    {
            //        if (n[j] == '1') { count++; }

            //    }

            //}
            //Console.WriteLine(count);
            //////////
            //////////  Console.WriteLine(" enter a number ");
            // long number = int.Parse(Console.ReadLine());
            //string n =  number.ToString();
            // long count = n.Length * ((number + 1) / 10);
            // Console.WriteLine(count);
            //////////
            /// //////////
            ///

            #endregion
            #region Day2 ITI    
            //Employee employee = new Employee();
            //bool res = false;
            //int count = 0;
            //do
            //{
            //    try
            //    {
            //        Console.WriteLine(" enter your id");
            //        employee.Id = int.Parse(Console.ReadLine());
            //        Console.WriteLine(" enter your securitylevel");
            //        employee.securitylevel = Console.ReadLine();
            //        Console.WriteLine(" enter your salary");
            //        employee.salary = int.Parse(Console.ReadLine());
            //        Console.WriteLine(" enter your Gender");
            //        employee.gen = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
            //        Console.WriteLine(" enter your Day");
            //        employee.day = int.Parse(Console.ReadLine());
            //        Console.WriteLine(" enter your Month");
            //        employee.month = int.Parse(Console.ReadLine());
            //        Console.WriteLine(" enter your Year");
            //        employee.year = int.Parse(Console.ReadLine());
            //        count++;
            //        res = false;

            //    }
            //    catch
            //    {
            //        res = true;
            //    }
            ///////
            //
            //while (res || count < 3);
            ///////////////////////
            ///
            //int[] arr = { 1, 2, 3 };
            //for (int i = 0; i < arr.Length-1; i+=2) {
            //    if (i < arr.Length)
            //    {
            //        int tmp = arr[i];
            //        arr[i] = arr[i+1];
            //        arr[i+1] = tmp;
            //    }
            //}
            //int[] arr2 = arr;
            //foreach (int i in arr2) { Console.WriteLine(i); }
            ////////////////////////////////////////
            ////

            #endregion
            #region train
            //int[] arr = { -110, 110, -38, -38, -62, 62, -38, -38, -38 };
            //List<int> list = new List<int>(arr);
            //Console.WriteLine(list.Count);
            //for (int i = 0; i < arr.Length; i++) {
            //    for (int j = 0;j< arr.Length; j++)
            //    {
            //        if (arr[i] == -arr[j] || -arr[i] == arr[j])
            //        {
            //            list.Remove(arr[i]);




            //        }

            //    }

            //}
            //foreach (int i in list) { Console.WriteLine(i); }

            ////////////////////////////////////////////
            ///


            //    int[] arr = { 5, 2 };
            //    int sum = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        sum += arr[i];
            //    }
            //    Console.WriteLine(sum);

            //    int count = 0;
            //    for (int i = 2; i < sum; i++)
            //    {

            //        if (sum % i == 0 || sum%2 == 0 )
            //        {
            //        sum++;
            //        count++;
            //    }


            //}


            //Console.WriteLine(count);

            ////////////////////////////////////////////
            ///
            //  Console.WriteLine(" enter your string");
            //  string str = Console.ReadLine();
            //string [] s =   str.Split(" ");
            //  //for (int i = 0; i < s.Length; i++) {
            //  //    Console.WriteLine(s[i]);
            //  //}
            //    //  train train = new train();
            //  int sum  = 0;
            //  for (int i = 0; i < s.Length; i++) {
            //      switch (s[i]) {
            //          case "zero":
            //              sum += 0; 
            //              break;
            //         case "one":
            //              sum += 1;
            //              break;
            //          case "two":
            //               sum += 2;
            //              break;
            //          case "three":
            //              sum += 3;
            //              break;
            //          case "four":
            //              sum += 4;
            //              break;
            //          case "five":
            //              sum += 5;
            //              break;
            //          case "six":
            //              sum += 6;
            //              break;
            //          case "seven":

            //              sum += 7;
            //              break;
            //          case "eight":
            //              sum += 8;
            //              break;
            //          case "nine":
            //              sum += 9;
            //              break;


            //      }

            //  }
            //  double avg = (double)sum / s.Length;
            //  Console.WriteLine(avg);
            //////////////////////////
            //Console.WriteLine(" enter a String ");
            //string str = Console.ReadLine();
            //string chars = "";
            //for (int i = 0; i < str.Length-1; i++)
            //{
            //    if (str[i] == str[i + 1])
            //        chars += str[i];
            //}
            //Console.WriteLine(chars.ToCharArray());
            //Console.WriteLine(IsPerfectPower(9));
            //Console.WriteLine(IsPerfectPower(5));
            //Console.WriteLine(IsPerfectPower(8));
            //Console.WriteLine(" enter number");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (Math.Pow(i, j) == n)
            //        {
            //            Console.WriteLine((i, j));
            //            return;
            //        }
            //    }
            //}

            //int[] arr = { 1040, 1220, 1580 };
            //int d = arr[1] - arr[0];
            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    if (arr[i] + d != arr[i + 1])
            //    {
            //        Console.WriteLine(arr[i] + d);
            //    }


            //}
            //        List<int> liss1 = [1,2,3];
            //        List<int> liss2 = [1,4,5];
            //         liss1.AddRange(liss2);
            //            liss1.Sort(); 
            //liss1.ToArray();
            ////foreach (int i in liss1)
            ////{


            ////    Console.WriteLine(i);
            ////}

            //Console.WriteLine(liss1);
            //////////////////////////////////
            //#region Employee salary mananagment System with Department
            //Department IT = new Department("IT");
            //Department HR = new Department("HR");
            ////FullTimeEmployee[] arr;
            ////PartTimeEmployee[] arr1;
            //Employee[] arr=  new Employee[2];
            //arr[0] = new FullTimeEmployee("mohamed",25000,IT,30);
            //arr[1] = new PartTimeEmployee("Mahmoud",3000,30000.30, HR);
            //foreach (var e in arr) {
            //    Console.WriteLine(e.CalculateSalary);
            //    Console.WriteLine(e.getDepartmentName());

            //}


            //#endregion
            //Test test = new Test();
            //Console.WriteLine(test.Factorial(6));
            //Console.WriteLine(test.Fibonacci(1));
            //Console.WriteLine(" enter a String ");
            //string s = Console.ReadLine();
            //char [] s1 = s.ToCharArray();
            //Console.WriteLine(" enter a part to remove it ");
            //string part = Console.ReadLine();
            //char[] part1 = part.ToCharArray();
            //List<char> part2 = new List<char>(part);
            //List<char> s2 = new List<char>(s1);
            //List<char> n = new List<char>(s2);

            //for (int i = 0; i < n.Count-1; i++)
            //{
            //    for (int j = 0; j < part2.Count-1; j++)
            //    {
            //        if (s2[i] == part2[j] && s2[i + 1] == part2[j + 1] && s2[i + 1] == part2[j + 1])
            //        {

            //            s2.Remove(s2[i]);
            //            s2.Remove(s2[i+1]);
            //            s2.Remove(s2[i+2]);
            //             n = new List<char>(s2);
            //        }
            //    }



            //    }
            //    foreach (char c in s2) { Console.WriteLine(c); }
            //Console.WriteLine("======================================");
            //foreach (char c in PART) { Console.WriteLine(c); }
            //for (int i = 0; i < s.Length; i++) {
            //    if (s.Contains(part))
            //    {
            //        s.Replace(part, " ");
            //    }

            //}
            //foreach (char c in s) { Console.WriteLine(c); }


            //Console.WriteLine(rem("daabcbaabcbc", "abc"));


            #endregion
            #region Delegates
            Console.WriteLine(" enter num1");
     
            int num1  = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter num2");
            int num2 = int.Parse(Console.ReadLine()); 
            //calc(num1, num2,'+');
            //calc(num1, num2,'-');
            //calc(num1, num2,'/');
            //calc(num1, num2,'*');
            //calcDelget c = new calcDelget(Add);

            // calc()
            Console.WriteLine(calc(num1, num2, delegate (int num1, int num2) { return num1 + num2; }));
            Console.WriteLine(calc(num1, num2, (int num1, int num2) => num1 % num2)); 
            Console.WriteLine(calc(num1, num2, (num1, num2) => num1 - num2)); 
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine(" enter a first string");
            string s1 = Console.ReadLine(); 
            Console.WriteLine(" enter a second string");
            string s2 = Console.ReadLine();
            Console.WriteLine(c(s1, s2, (s1, s2) => s1 + " "+s2 ));
            Console.WriteLine(c(s1,s2 ,(string s1,string s2 ) =>s1 + s2));
            //#endregion






            #endregion
            //Console.WriteLine("k");
            //List<em> employe = new List<em>();
            //for (var i = 0; i < 100; i++) {
            //    employe.Add(new em
            //    {
            //        name = $"employee {i}",
            //        basicsalary = Random.Shared.Next(1000, 5000),
            //        Deduc = Random.Shared.Next(0, 501),
            //        bonus = Random.Shared.Next(0, 1001)
            //    });
            //}


        }

        //static string rem(string s, string part)
        //{


        //    char[] s1 = s.ToCharArray();
        //    char[] part1 = part.ToCharArray();
        //    List<char> part2 = new List<char>(part);
        //    List<char> s2 = new List<char>(s1);
        //    List<char> n = new List<char>(s2);

        //    for (int i = 0; i < n.Count - 1; i++)
        //    {
        //        for (int j = 0; j < part2.Count - 1; j++)
        //        {
        //            if (s2[i] == part2[j] && s2[i + 1] == part2[j + 1] && s2[i + 1] == part2[j + 1])
        //            {

        //                s2.Remove(s2[i]);
        //                s2.Remove(s2[i + 1]);
        //                s2.Remove(s2[i + 2]);
        //                n = new List<char>(s2);
        //            }
        //        }



        //    }
        //    string x = string.Join(",", n);
        //    return rem(x,part);
        //}
        static int calc(int num1, int num2, calcDelgetint dlg)
        {
            int result = dlg(num1, num2);
            //Console.WriteLine(result);
            return result;
        }
        static string c(string X, string y , calcDelgetstring dlg ) { 
            string S = dlg(X, y);
            return S;

        }

            //}
            //static int Add(int x, int y)
            //{
            //    Console.WriteLine("Add");
            //    return x + y;

            //}
            //static int sub(int x, int y)
            //{
            //    Console.WriteLine("sub");
            //    return x - y;

            //}
            //static int mult(int x, int y)
            //{
            //    Console.WriteLine("mult");
            //    return x * y;

            //}
            //static int Div(int x, int y)
            //{
            //    Console.WriteLine("Div");
            //    return x / y;

            //}
        }

    }

