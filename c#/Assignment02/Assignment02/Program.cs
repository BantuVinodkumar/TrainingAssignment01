using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //find min,max & avg
            Console.WriteLine("Enter array size");
            int[] ar = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("the elements at " + i);
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the elements are");
            for (int i = 0; i < ar.Length; i++)
            {


                Console.Write(ar[i] + " ");
            }
            Console.WriteLine("the average of elements: " + ar.Average());
            Console.WriteLine("the min element: " + ar.Min() + " " + "and " + "the max element: " + ar.Max());

            //marks
            Console.WriteLine("\nEnter marks");
            int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("the elements at " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the elements are");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            //asscending
            Array.Sort(arr);
            Console.WriteLine("\narray after sort in ascending order...");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }


            //descending
            Array.Reverse(arr);
            Console.WriteLine("\narray after sort in descending order...");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nthe sum of elements: " + arr.Sum() + " " + "and " + "the average of element: " + arr.Average());
            Console.WriteLine("\nthe min element: " + arr.Min() + " " + "and " + "the max element: " + arr.Max());



            //accept and display length 

            Console.WriteLine("\nEnter a String");
            string s1 = Console.ReadLine();
            Console.WriteLine("The given input: " + s1.Length);

            //string reverse
            Console.WriteLine("\nEnter a String");
            string s2 = Console.ReadLine();
            String revs = "";
            for (int i = s2.Length - 1; i >= 0; i--) 
            {
                revs += s2[i].ToString();
            }
            Console.WriteLine("The reversed String : " + revs);

            //string value equal or not equal
            Console.WriteLine("\nEnter the first string ");
            string s5 = Console.ReadLine();
            Console.WriteLine("\nEnter the second string ");
            string s6 = Console.ReadLine();
            if (s5 == s6)
            {
                Console.WriteLine("string s5 {0} and string s6 {1} are equal ",s5,s6);
            }
            else
            {
                Console.WriteLine("string s5 {0} and string s6 {1} are not equal ", s5, s6);
            }

            //Palindrome
            Console.WriteLine("\nEnter a string");
            string s = Console.ReadLine();
            String rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i].ToString();
            }
            if (rev == s) 
            {
                Console.WriteLine("the string is {0} and reversed string is {1}  its a palindrome.",s,rev);
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }
            Console.ReadLine();

           


            

        }
    }
}
