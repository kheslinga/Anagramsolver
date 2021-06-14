using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net.Http;


namespace AnagramSolver
{
    class Program
    {
        static List<String> permutations = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Specify language: [NL] or [ENG]");
            String language = Console.ReadLine();
            Console.WriteLine("Enter string to check for anagrams");
            char[] input = Console.ReadLine().ToCharArray();
            DoPermutation(input, 0);
            foreach(String str in permutations)
            {
                Console.WriteLine(str);
            }
            APIHelper.test();
            Console.ReadLine();
        }
        static void DoPermutation(char[] charArray, int index)
        {
            if(index == charArray.Length - 1)
            {
                permutations.Add(new string(charArray));
                return;
            }
            for(int i = index; i < charArray.Length; i++)
            {
                DoPermutation(SwapPositions(charArray, index, i),index + 1);
            }
        }
        static char[] SwapPositions(char[] charArray, int a, int b)
        {
            char temp = charArray[b];
            charArray[b] = charArray[a];
            charArray[a] = temp;
            return charArray;
        }
    }
}
