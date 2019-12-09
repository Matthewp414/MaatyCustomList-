using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MattyList;

namespace MattyListTest
{
    [TestClass]
    public class MattyListUnitTesting
    {
        [TestMethod]
        public void IncrementCounterTest1_Int_Count1()
        {
            //Arrange
            MattyList<int> list = new MattyList<int>();
            int excepected = 0;
            excepected++;
            //Act
            list.IncrementCount(1);
            int actual = list.Count;
            //Assert
            Assert.AreEqual(excepected, actual);
            
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IncrementCounterTest2_Int_Exception()
        {
            MattyList<int> list = new MattyList<int>();
            //Act
            list.IncrementCount(-1);
        }
        [TestMethod]
        public void AddUnitTest1_Int_ArrayOf_1()
        {
            //Arrange
            MattyList<int> list = new MattyList<int>();
            int excepected =  1;

            //Act
            list.MattyAdd(1);
            int actual = list[0];
            //Assert
            Assert.AreEqual(excepected, actual);


        }
        [TestMethod]
        public void AddUnitTest2_Int_ArrayOf_string_hey()
        {
            //Arrange
            MattyList<string> list = new MattyList<string>();
             string excepected = "hey";

            //Act
            list.MattyAdd("hey");
            string actual = list[0];
            //Assert
            Assert.AreEqual(excepected, actual);


        }
        [TestMethod]
        public void AddUnitTest3_Int_ArrayOf_double_1_0()
        {
            //Arrange
            MattyList<double> list = new MattyList<double>();

            double excepected = 1;
            double excepected2 = 0;   

            //Act
            list.MattyAdd(1);
            list.MattyAdd(0);
            double actual = list[0];
            double actual2 = list[1];
            //Assert
            Assert.AreEqual(excepected, actual);
            Assert.AreEqual(excepected2, actual2);



        }
        [TestMethod]
        public void AddUnitTest4_Int_ArrayOf_decimal_2point1_2point2()
        {
            //Arrange
            MattyList<decimal> list = new MattyList<decimal>();

            decimal excepected = 2.1m;
            decimal excepected2 =  2.2m;

            //Act
            list.MattyAdd(2.1m);
            list.MattyAdd(2.2m);
            decimal actual = list[0];
            decimal actual2 = list[1];
            //Assert
            Assert.AreEqual(excepected, actual);
            Assert.AreEqual(excepected2, actual2);
        }
        [TestMethod]
        public void AddUnitTest5_Int_ArrayOf_decimal_Capacint()
        {
            //Arrange
            MattyList<decimal> list = new MattyList<decimal>();

            int excepected = 8;
            

            //Act
            list.MattyAdd(2.1m);
            list.MattyAdd(2.2m);
            list.MattyAdd(2.3m);
            list.MattyAdd(2.4m);
            list.MattyAdd(2.5m);
            list.MattyAdd(2.6m);

            int actual = list.Capacity;
            
            //Assert
            Assert.AreEqual(excepected, actual);
        }
        [TestMethod]
        public void RemoveUnitTest1_Int_ArrayOf_T()
        {
            //Arrange
            MattyList<string> list = new MattyList<string>();

            int excepected = 2;


            //Act
            list.MattyAdd("Hi");
            list.MattyAdd("Guy");
            list.MattyAdd("What");
            list.MattyRemove( "What");
            int actual = list.Count;

            //Assert
            Assert.AreEqual(excepected, actual);
        }

        [TestMethod]
        public void RemoveUnitTest2_Int_ArrayOf_T()
        {
            //Arrange
            MattyList<string> list = new MattyList<string>();

            MattyList<string> excepected = new MattyList<string>[] { "Hi", "Guy" };

            //Act
            list.MattyAdd("Hi");
            list.MattyAdd("Guy");
            list.MattyAdd("What");
            list.MattyRemove("What");
            MattyList<string> actual = list;


            //Assert
            Assert.AreEqual(excepected, actual);
        }
        [TestMethod]
        public void RemoveUnitTest3_Int_ArrayOf_T()
        {
            //Arrange
            MattyList<string> list = new MattyList<string>();

            MattyList<string> excepected = new MattyList<string>[] { "Hi"};

            //Act
            list.MattyAdd("Hi");
            list.MattyAdd("Guy");
            list.MattyAdd("What");
            list.MattyRemove("What");
            list.MattyRemove("Guy");
            MattyList <string> actual = list;

            //Assert
            Assert.AreEqual(excepected, actual);
        }
        [TestMethod]
        public void RemoveUnitTest4_Int_ArrayOf_T()
        {
            //Arrange
            MattyList<string> list = new MattyList<string>();

            int excepected = 3;

            //Act
            list.MattyAdd("Hi");
            list.MattyAdd("Guy");
            list.MattyAdd("What");
            list.MattyRemove("a");

            int actual = list.Count;

            //Assert
            Assert.AreEqual(excepected, actual);
        }
        [TestMethod]
        public void RemoveUnitTest5_Int_ArrayOf_T()
        {
            //Arrange
            MattyList<int> list = new MattyList<int>();

            int excepected = 2;

            //Act
            list.MattyAdd(1);
            list.MattyAdd(2);
            list.MattyAdd(3);
            list.MattyRemove(1);

            int actual = list.Count;

            //Assert
            Assert.AreEqual(excepected, actual);
        }
        [TestMethod]
        public void ToStringUnitTest1_String_ArrayOf_T()
        {
            //Arrange
            MattyList<int> list = new MattyList<int>();

            string excepected = "1";

            //Act
            list.MattyAdd(1);

            list.MattyToString();
            
            string actual = list[0];

            //Assert
            Assert.AreEqual(excepected, actual);
        }
        [TestMethod]
        public void ToStringUnitTest2_String_ArrayOf_T()
        {
            //Arrange
            MattyList<double> list = new MattyList<double>();

            string excepected = "1";

            //Act
            list.MattyAdd(1.0);

            list.MattyToString();

            string actual = list[0];

            //Assert
            Assert.AreEqual(excepected, actual);
        }
    }
}

