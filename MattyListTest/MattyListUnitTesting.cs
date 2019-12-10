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
            list.Add(1);
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
            list.Add("hey");
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
            list.Add(1);
            list.Add(0);
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
            list.Add(2.1m);
            list.Add(2.2m);
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
            list.Add(2.1m);
            list.Add(2.2m);
            list.Add(2.3m);
            list.Add(2.4m);
            list.Add(2.5m);
            list.Add(2.6m);

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
            list.Add("Hi");
            list.Add("Guy");
            list.Add("What");
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

            string excepected = null;
            


            //Act
            list.Add("Hi");
            list.Add("Guy");
            list.Add("What");
            list.MattyRemove("What");
            string actual = list[3];


            //Assert
            Assert.AreEqual(excepected, actual);
        }
        [TestMethod]
        public void RemoveUnitTest3_Int_ArrayOf_T()
        {
            //Arrange
            MattyList<string> list = new MattyList<string>();

            string excepected = null;
            string excepected2 = null;


            //Act
            list.Add("Hi");
            list.Add("Guy");
            list.Add("What");
            list.MattyRemove("What");
            list.MattyRemove("Guy");
            string actual = list[1];
            string actual2 = list[2];

            //Assert
            Assert.AreEqual(excepected, actual);
            Assert.AreEqual(excepected2, actual2);

        }
        [TestMethod]
        public void RemoveUnitTest4_Int_ArrayOf_T()
        {
            //Arrange
            MattyList<string> list = new MattyList<string>();

            int excepected = 3;

            //Act
            list.Add("Hi");
            list.Add("Guy");
            list.Add("What");
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
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.MattyRemove(1);

            int actual = list.Count;

            //Assert
            Assert.AreEqual(excepected, actual);
        }
        [TestMethod]
        public void ToStringUnitTest1_String_ArrayOf_T()
        {
            //Arrange
            MattyList<string> list = new MattyList<string>();

            string excepected = "a b c ";

            //Act
            list.Add("a");
            list.Add("b");
            list.Add("c");
            
            
            string actual = list.MattyToString();

            //Assert
            Assert.AreEqual(excepected, actual);
        }
        [TestMethod]
        public void ToStringUnitTest2_String_ArrayOf_T()
        {
            //Arrange
            MattyList<double> list = new MattyList<double>();

            string excepected = "1 2 3 ";

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            string actual = list.MattyToString();

             

            //Assert
            Assert.AreEqual(excepected, actual);
        }
        [TestMethod]
        public void PlustOverLoadUnitTest1_String_ArrayOf_T()
        {
            //Arrange
            MattyList<string> list1 = new MattyList<string> { "1"};
            MattyList<string> list2 = new MattyList<string> { "1"};
            MattyList<string> list3 = list1 - list2;

            string excepected = null;

            //Act
            
            string actual = list3[0];



            //Assert
            Assert.AreEqual(excepected, actual);
        }
        [TestMethod]
        public void MinusOverLoadUnitTest1_String_ArrayOf_T()
        {
            //Arrange
            MattyList<string> list1 = new MattyList<string> { "1" };
            MattyList<string> list2 = new MattyList<string> { "1" };
            MattyList<string> list3 = list1 + list2;

            string excepected = "1";
            string excepected2 = "1";


            //Act


            string actual = list3[0];
            string actual2 = list3[0];




            //Assert
            Assert.AreEqual(excepected, actual);
            Assert.AreEqual(excepected2, actual2);

        }
        [TestMethod]

        public void ZipUnitTest_Int_ArrayOf_T()
        {
            //Arrange
            MattyList<int> list1 = new MattyList<int> { 1, 2, 3 };
            MattyList<int> list2 = new MattyList<int> { 1, 2, 3 };
            

            int excepected = 1;
            int excepected2 = 1;


            //Act
            list1.Zip(list2);

            int actual = list1[0];
            int actual2 = list1[1];




            //Assert
            Assert.AreEqual(excepected, actual);
            Assert.AreEqual(excepected2, actual2);

        }
        [TestMethod]

        public void ZipUnitTest2_Int_ArrayOf_T()
        {
            //Arrange
            MattyList<int> list1 = new MattyList<int> { 1, 2, 3 };
            MattyList<int> list2 = new MattyList<int> { 1, 2, 3 };


            int excepected = 2;
            int excepected2 = 2;


            //Act
            list1.Zip(list2);

            int actual = list1[2];
            int actual2 = list1[3];




            //Assert
            Assert.AreEqual(excepected, actual);
            Assert.AreEqual(excepected2, actual2);

        }
        [TestMethod]
        public void ZipUnitTest3_Int_ArrayOf_T()
        {
            //Arrange
            MattyList<int> list1 = new MattyList<int> { 1, 2, 3 };
            MattyList<int> list2 = new MattyList<int> { 1, 2, 3 };


            int excepected = 8;
            


            //Act
            list1.Zip(list2);

            int actual = list1.Capacity;
            



            //Assert
            Assert.AreEqual(excepected, actual);
            

        }
        [TestMethod]

        public void ZipUnitTest4_Int_ArrayOf_T()
        {
            //Arrange
            MattyList<int> list1 = new MattyList<int> { 1, 2, 3 };
            MattyList<int> list2 = new MattyList<int> { 1, 2, 3 };


            int excepected = 6;



            //Act
            list1.Zip(list2);

            int actual = list1.Count;




            //Assert
            Assert.AreEqual(excepected, actual);


        }
    }
}

