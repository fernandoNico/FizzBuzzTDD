using FizzBuzzLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTests
{

    [TestFixture]
    public class FizzBuzzerTests
    {

        //[Test]
        //public void BuzzerWhen1Returns1()
        //{
        //    //Arrange
        //    int input = 1;

        //    //Act
        //    string output = FizzBuzzer.GetValue(input);

        //    //Assert
        //    Assert.AreEqual("1", output);

        //}

        [Test]
        public void BuzzerWhenDefaultReturnsInput(
            [Values(1,2,4, 7 , 8 , 11, 13, 14,16,17,19)] int input)
        {
            //Arrange
            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual(input.ToString(), output);

        }


        [Test]
        public void BuzzerWhenDiv3ReturnsFizz(
            [Values(3, 6, 9, 12,18)] int input)
        {
    
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);

        }

        [Test]
        public void BuzzerWhen5ReturnsBuzz(
            [Values(5, 10,20)] int input)
        {
           
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);

        }

        [Test]
        public void BuzzerWhenDiv3andDiv5ReturnFizzBuzz(
           [Values(15)] int input)
        {

            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);

        }




    }
}
