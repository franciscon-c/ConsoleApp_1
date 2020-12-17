using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp_1.Test
{
    [TestClass]
    public class Tests
    {
        #region CountDs
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
        //[TestMethod]
        //public void TestMethod16()
        //{
        //    var result = Program.ReverseCase("Happy Birthday");

        //    Assert.AreEqual("hAPPY bIRTHDAY", result);
        //}

        //[TestMethod]
        //public void TestMethod17()
        //{
        //    var result = Program.ReverseCase("MANY THANKS");

        //    Assert.AreEqual("many thanks", result);
        //}

        //[TestMethod]
        //public void TestMethod18()
        //{
        //    var result = Program.ReverseCase("sPoNtAnEoUs");

        //    Assert.AreEqual("SpOnTaNeOuS", result);
        //}

        //[TestMethod]
        //public void TestMethod19()
        //{
        //    var result = Program.ReverseCase("eXCELLENT, yOuR mAJESTY");

        //    Assert.AreEqual("Excellent, YoUr Majesty", result);
        //}
        #endregion

        #region ArrayOfMultiples
        //[TestMethod]
        //public void TestMethod20()
        //{
        //    var result = Program.ArrayOfMultiples(7, 5);

        //    CollectionAssert.AreEqual(new int[] { 7, 14, 21, 28, 35 }, result);
        //}

        //[TestMethod]
        //public void TestMethod21()
        //{
        //    var result = Program.ArrayOfMultiples(12, 10);

        //    CollectionAssert.AreEqual(new int[] { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 }, result);
        //}

        //[TestMethod]
        //public void TestMethod22()
        //{
        //    var result = Program.ArrayOfMultiples(17, 7);

        //    CollectionAssert.AreEqual(new int[] { 17, 34, 51, 68, 85, 102, 119 }, result);
        //}

        //[TestMethod]
        //public void TestMethod23()
        //{
        //    var result = Program.ArrayOfMultiples(630, 14);

        //    CollectionAssert.AreEqual(new int[] { 630, 1260, 1890, 2520, 3150, 3780, 4410, 5040, 5670, 6300, 6930, 7560, 8190, 8820 }, result);
        //}

        //[TestMethod]
        //public void TestMethod24()
        //{
        //    var result = Program.ArrayOfMultiples(140, 3);

        //    CollectionAssert.AreEqual(new int[] { 140, 280, 420 }, result);
        //}

        //[TestMethod]
        //public void TestMethod25()
        //{
        //    var result = Program.ArrayOfMultiples(7, 8);

        //    CollectionAssert.AreEqual(new int[] { 7, 14, 21, 28, 35, 42, 49, 56 }, result);
        //}

        //[TestMethod]
        //public void TestMethod26()
        //{
        //    var result = Program.ArrayOfMultiples(11, 21);

        //    CollectionAssert.AreEqual(new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110, 121, 132, 143, 154, 165, 176, 187, 198, 209, 220, 231 }, result);
        //}
        #endregion

        #region KaracaEncrypt
        //[TestMethod]
        //public void TestMethod27()
        //{
        //    var result = Program.Encrypt("karaca");

        //    Assert.AreEqual("0c0r0kaca", result);
        //}

        //[TestMethod]
        //public void TestMethod28()
        //{
        //    var result = Program.Encrypt("burak");

        //    Assert.AreEqual("k0r3baca", result);
        //}

        //[TestMethod]
        //public void TestMethod29()
        //{
        //    var result = Program.Encrypt("alpaca");

        //    Assert.AreEqual("0c0pl0aca", result);
        //}

        //[TestMethod]
        //public void TestMethod30()
        //{
        //    var result = Program.Encrypt("banana");

        //    Assert.AreEqual("0n0n0baca", result);
        //}

        //[TestMethod]
        //public void TestMethod31()
        //{
        //    var result = Program.Encrypt("hello");

        //    Assert.AreEqual("2ll1haca", result);
        //}
        #endregion

        #region PricingCalculation
        
        #endregion
    }
}
