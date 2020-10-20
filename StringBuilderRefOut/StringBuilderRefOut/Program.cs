using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Method task
            //Console.WriteLine(CustomPower(2, 0));
            //int[] arr1 = { 10, 20, 30, 40 };
            //int[] arr2 = { 30, 50, 60, 20 };
            //GetSameValue(arr1, arr2);
            //Console.WriteLine(CustomJoin(new string[4] { "Melek", "Turkan", "Mircavid", "Kamran" }));
            #endregion

            #region ref,out
            //int a=5;
            //Bashlangicda deyishene deyer verilmelidir!!! Method-da deyishmeye bilersen
            //ChangeValue(ref a);
            //Console.WriteLine(a);

            //out-in method must be assigned.Bashlangicda hech bir deyer vermeye bilersiz
            //ChangeValueOut(out a);
            //Console.WriteLine(a);
            //Console.WriteLine("Yashinizi daxil edin:");
            //string age = Console.ReadLine();
            //int result;
            //bool res = int.TryParse(age, out result);
            //if (res)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Zehmet olmasa eded daxil edin");
            //}



            #endregion

            #region Array methods
            //int[] arr = new int[3] { 10, 20, 30 };
            //Console.WriteLine(arr.Length);
            //Array.Resize(ref arr,4);
            //string[] arr = { "Kamran", "Elgun", "Ibrahim" };
            //bool r=arr.Contains("Kamran");
            //Console.WriteLine(r);
            //string r=String.Join(",", arr);
            //Console.WriteLine(r);
            //Array.Reverse(arr);
            //Console.WriteLine(arr[0]);
            //Array.Clear(arr, 1, 2);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] arr = { 5, 2,10, 1, 4, 3 };
            //double r=arr.Average();
            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Max());
            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region String methods
            //string str = "Hello World";
            //Console.WriteLine(str.Trim());
            //Console.WriteLine(str[0]);
            //Console.WriteLine(str.ToLower());
            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.Contains("He"));
            //string[] arr=str.Split(' ');
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region StringBuilder
            //Console.WriteLine(CustomJoin(new string[] { "Kamran", "Nahide", "Camal" }));
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Vasif");
            stringBuilder.Insert(5, " Xammedov");
            //stringBuilder.Remove(1, 2);
            stringBuilder.Replace(' ', '-');
            stringBuilder.Clear();
            Console.WriteLine(stringBuilder);
            #endregion
        }

        #region StringBuilder
        static StringBuilder CustomJoin(string[] arr)
        {
            StringBuilder result = new StringBuilder();
            foreach (string word in arr)
            {
                result.Append(word);
                if (word != arr[arr.Length - 1])
                {
                    result.Append(",");
                }
            }
            return result;
        }
        #endregion

        #region ref,out
        static void ChangeValue(ref int a)
        {
            Console.WriteLine("method: " + a);
        }

        static void ChangeValueOut(out int a)
        {
            a = 10;
            Console.WriteLine("method: " + a);
        }
        #endregion

        #region Method task
        static int CustomPower(int num, int pow)
        {
            int result = 1;
            while (pow > 0)
            {
                result *= num;
                pow--;
            }
            return result;
        }

        static void GetSameValue(int[] arr1, int[] arr2)
        {
            foreach (int item1 in arr1)
            {
                foreach (int item2 in arr2)
                {
                    if (item1 == item2)
                        Console.WriteLine(item1);
                }
            }
        }

        //static string CustomJoin(string[] arr)
        //{
        //    string result = "";
        //    foreach (string word in arr)
        //    {
        //        result += word;
        //        if (word != arr[arr.Length - 1])
        //        {
        //            result += ",";
        //        }
        //    }
        //    return result;
        //}

        
        #endregion

    }
}
