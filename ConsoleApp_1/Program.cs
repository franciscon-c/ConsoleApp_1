namespace ConsoleApp_1
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int CountDs(string str)
        {
            // Create a function that counts how many D's are in a sentence.
            // CountDs("My friend Dylan got distracted in school.") => 4

            return default;
        }

        public static string SmallerNum(string n1, string n2)
        {
            //Create a function that returns the smaller number.
            //If both numbers tie, return either number.
            //SmallerNum("21", "44") => "21"

            return default;
        }

        public static string Repetition(string txt, int n)
        {
            //Create a recursive function that takes two parameters and repeats the string n number of times. 
            //The first parameter txt is the string to be repeated and the second parameter is the number of times the string is to be repeated.
            //Repetition("ab", 3) => "ababab"

            return default;
        }

        public static string ReverseCase(string str)
        {
            //Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
            //ReverseCase("Happy Birthday") => "hAPPY bIRTHDAY"

            return default;
        }

        public static int[] ArrayOfMultiples(int num, int length)
        {
            //Create a function that takes two numbers as arguments(num, length) and returns an array of multiples of num until the array length reaches length.
            //ArrayOfMultiples(7, 5) => [7, 14, 21, 28, 35]

            return default;
        }

        public static string Encrypt(string word)
        {
            //Make a function that encrypts a given input with these steps:
            //Input: "apple"
            //Step 1: Reverse the input
            //Step 2: Replace all vowels using the following chart:
            //a => 0
            //e => 1
            //i => 2
            //o => 2
            //u => 3
            //Step 3: Add "aca" to the end of the word
            //Encrypt("banana") => "0n0n0baca"

            return default;
        }

        //Make a function that calculates discount according to a given input following these rules:
        //Input must be a membership level value from the following chart and a price:
        //Bronze => discount 5%
        //Silver => discount 10%
        //Gold => discount 15%
        //Platinum => discount = 25%
        //Each membershiplevel should have its own class and implement the same interface with a method to calculate price with discount
        //Depending on the membership level the function should create an instance of the class and calculate the price with discount
        //If input does not match any membership level, original price should be returned
        //DiscountedPrice(Bronze, 25) => 23.75
    }
}