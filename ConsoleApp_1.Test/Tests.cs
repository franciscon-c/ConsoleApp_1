using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp_1.Test
{
    [TestClass]
    public class Tests
    {
        #region CountDs
        // Create a function that counts how many D's are in a sentence.
        // CountDs("My friend Dylan got distracted in school.") => 4

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    var result = Program.CountDs("My friend Dylan got distracted at school");

        //    Assert.AreEqual(4, result);
        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    var result = Program.CountDs("Debris was scattered all over the place.");

        //    Assert.AreEqual(2, result);
        //}

        //[TestMethod]
        //public void TestMethod3()
        //{
        //    var result = Program.CountDs("The rodents hibernated in their den.");

        //    Assert.AreEqual(3, result);
        //}
        #endregion

        #region SmallerNum
        //Create a function that returns the smaller number.
        //If both numbers tie, return either number.
        //SmallerNum("21", "44") => "21"

        //[TestMethod]
        //public void TestMethod4()
        //{
        //    var result = Program.SmallerNum("21", "44");

        //    Assert.AreEqual("21", result);
        //}

        //[TestMethod]
        //public void TestMethod5()
        //{
        //    var result = Program.SmallerNum("153", "367");

        //    Assert.AreEqual("153", result);
        //}

        //[TestMethod]
        //public void TestMethod6()
        //{
        //    var result = Program.SmallerNum("1500", "16");

        //    Assert.AreEqual("16", result);
        //}

        //[TestMethod]
        //public void TestMethod7()
        //{
        //    var result = Program.SmallerNum("100", "23");

        //    Assert.AreEqual("23", result);
        //}

        //[TestMethod]
        //public void TestMethod8()
        //{
        //    var result = Program.SmallerNum("1500", "1");

        //    Assert.AreEqual("1", result);
        //}

        //[TestMethod]
        //public void TestMethod9()
        //{
        //    var result = Program.SmallerNum("5", "5");

        //    Assert.AreEqual("5", result);
        //}
        #endregion

        #region Repetition
        //Create a recursive function that takes two parameters and repeats the string n number of times. 
        //The first parameter txt is the string to be repeated and the second parameter is the number of times the string is to be repeated.
        //Repetition("ab", 3) => "ababab"

        //[TestMethod]
        //public void TestMethod10()
        //{
        //    var result = Program.Repetition("soccer", 2);

        //    Assert.AreEqual("soccersoccer", result);
        //}

        //[TestMethod]
        //public void TestMethod11()
        //{
        //    var result = Program.Repetition("ab", 3);

        //    Assert.AreEqual("ababab", result);
        //}

        //[TestMethod]
        //public void TestMethod12()
        //{
        //    var result = Program.Repetition("this", 1);

        //    Assert.AreEqual("this", result);
        //}

        //[TestMethod]
        //public void TestMethod13()
        //{
        //    var result = Program.Repetition("ciao", 4);

        //    Assert.AreEqual("ciaociaociaociao", result);
        //}

        //[TestMethod]
        //public void TestMethod14()
        //{
        //    var result = Program.Repetition("charon", 5);

        //    Assert.AreEqual("charoncharoncharoncharoncharon", result);
        //}

        //[TestMethod]
        //public void TestMethod15()
        //{
        //    var result = Program.Repetition("sa", 10);

        //    Assert.AreEqual("sasasasasasasasasasa", result);
        //}
        #endregion

        #region ReverseCase
        //Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
        //ReverseCase("Happy Birthday") => "hAPPY bIRTHDAY"

        [TestMethod]
        public void TestMethod1()
        {
            var result = Program.ReverseCase("Happy Birthday");

            Assert.AreEqual("hAPPY bIRTHDAY", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = Program.ReverseCase("MANY THANKS");

            Assert.AreEqual("many thanks", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = Program.ReverseCase("sPoNtAnEoUs");

            Assert.AreEqual("SpOnTaNeOuS", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = Program.ReverseCase("eXCELLENT, yOuR mAJESTY");

            Assert.AreEqual("Excellent, YoUr Majesty", result);
        }
        #endregion

        #region ArrayOfMultiples
        //Create a function that takes two numbers as arguments(num, length) and returns an array of multiples of num until the array length reaches length.
        //ArrayOfMultiples(7, 5) => [7, 14, 21, 28, 35]

        [TestMethod]
        public void TestMethod5()
        {
            var result = Program.ArrayOfMultiples(7, 5);

            CollectionAssert.AreEqual(new int[] { 7, 14, 21, 28, 35 }, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var result = Program.ArrayOfMultiples(12, 10);

            CollectionAssert.AreEqual(new int[] { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 }, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var result = Program.ArrayOfMultiples(17, 7);

            CollectionAssert.AreEqual(new int[] { 17, 34, 51, 68, 85, 102, 119 }, result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var result = Program.ArrayOfMultiples(630, 14);

            CollectionAssert.AreEqual(new int[] { 630, 1260, 1890, 2520, 3150, 3780, 4410, 5040, 5670, 6300, 6930, 7560, 8190, 8820 }, result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            var result = Program.ArrayOfMultiples(140, 3);

            CollectionAssert.AreEqual(new int[] { 140, 280, 420 }, result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            var result = Program.ArrayOfMultiples(7, 8);

            CollectionAssert.AreEqual(new int[] { 7, 14, 21, 28, 35, 42, 49, 56 }, result);
        }

        [TestMethod]
        public void TestMethod11()
        {
            var result = Program.ArrayOfMultiples(11, 21);

            CollectionAssert.AreEqual(new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110, 121, 132, 143, 154, 165, 176, 187, 198, 209, 220, 231 }, result);
        }
        #endregion

        #region KaracaEncrypt
        //Make a function that encrypts a given input with these steps:
        //Input: "apple"
        //Step 1: Reverse the input: "elppa"
        //Step 2: Replace all vowels using the following chart:
        //a => 0
        //e => 1
        //i => 2
        //o => 2
        //u => 3
        // "1lpp0"
        //Step 3: Add "aca" to the end of the word: "1lpp0aca"
        //Output: "1lpp0aca"
        //Encrypt("banana") => "0n0n0baca"

        [TestMethod]
        public void TestMethod12()
        {
            var result = Program.Encrypt("karaca");

            Assert.AreEqual("0c0r0kaca", result);
        }

        [TestMethod]
        public void TestMethod13()
        {
            var result = Program.Encrypt("burak");

            Assert.AreEqual("k0r3baca", result);
        }

        [TestMethod]
        public void TestMethod14()
        {
            var result = Program.Encrypt("alpaca");

            Assert.AreEqual("0c0pl0aca", result);
        }

        [TestMethod]
        public void TestMethod15()
        {
            var result = Program.Encrypt("banana");

            Assert.AreEqual("0n0n0baca", result);
        }

        [TestMethod]
        public void TestMethod16()
        {
            var result = Program.Encrypt("hello");

            Assert.AreEqual("2ll1haca", result);
        }
        #endregion


    }
}
