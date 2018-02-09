using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace MorseTask.Test
{
    [TestClass]
    public class MorseEncryptorTest
    {
        public IEncryptor encryptor = new MorseEncryptor();

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Encode_Null_Exception()
        {
            string result = encryptor.Encode(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Encode_EmptyString_Exception()
        {
            string result = encryptor.Encode("");
        }

        [TestMethod]
        public void Test_Encode_SOSMessage_NumberOfSingleSpace()
        {
            string result = encryptor.Encode("cat");
            int numberOfSingleSpaceBetweenLetters = result.Count(Char.IsWhiteSpace);
            Assert.AreEqual(2, numberOfSingleSpaceBetweenLetters);
        }

        [TestMethod]
        public void Test_Encode_CatInHatMessage_CatInHatMessageEncodedInMorse()
        {
            string expectedResult = "-.-. .- -  .. -.  .... .- -";
            string result = encryptor.Encode("cat in hat");
            Assert.AreEqual(expectedResult, result);          
        }

        [TestMethod]
        public void Test_Encode_SOSMessage_SOSMessageEncodedInMorse()
        {
            string expectedResult = "... --- ...";
            string result = encryptor.Encode("SOS");
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_Encode_SOSMessageLowerCase_SOSMessageEncodedInMorse()
        {
            string expectedResult = "... --- ...";
            string result = encryptor.Encode("sos");
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_Encode_SOSMessageMixedCase_SOSMessageEncodedInMorse()
        {
            string expectedResult = "... --- ...";
            string result = encryptor.Encode("sOs");
            Assert.AreEqual(expectedResult, result);
        }

        //because base constructor supports only letters.
        [TestMethod]
        [ExpectedException(typeof(System.Collections.Generic.KeyNotFoundException))]
        public void Test_Encode_MessageWithNumbers_Exception()
        {
            string result = encryptor.Encode("123");
        }

        //because base constructor supports only letters.
        [TestMethod]
        [ExpectedException(typeof(System.Collections.Generic.KeyNotFoundException))]
        public void Test_Encode_MessageWithSpecialCharacters_Exception()
        {
            string result = encryptor.Encode("...");
        }
    }
}