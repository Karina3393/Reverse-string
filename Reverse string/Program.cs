namespace Reverse_string
{
    internal class Program;

    class ReverseString
    {

        public static string Reverse(string input)
        {

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {

            string str1 = "stressed";
            string str2 = "sports";
            string str3 = "racecar";


            Console.WriteLine(Reverse(str1));
            Console.WriteLine(Reverse(str2));
            Console.WriteLine(Reverse(str3));
        }
    }
}
