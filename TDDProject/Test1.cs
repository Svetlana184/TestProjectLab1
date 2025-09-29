namespace TDDProject
{
    [TestClass]
    public sealed class TestTriangle
    {
        ///<summary>
        ///Позитивный тест
        ///Треугольник прямоугольный
        ///<summary/>
        [TestMethod]
        public void TestMethod1()
        {
            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.A = 3;
            rightTriangle.B = 4;
            rightTriangle.C = 5;
            Assert.IsTrue(rightTriangle.IsRight());
        }
        ///<summary>
        ///Негативный тест
        ///Треугольник прямоугольный
        ///<summary/>
        [TestMethod]
        public void TestMethod2()
        {
            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.A = 3;
            rightTriangle.B = 4;
            rightTriangle.C = 4;
            Assert.IsFalse(rightTriangle.IsRight());
        }
        ///<summary>
        ///Позитивный тест
        ///Треугольник прямоугольный
        ///<summary/>
        [TestMethod]
        public void IsRightTestA()
        {
            RightTriangle rightTriangle = new RightTriangle();
             rightTriangle.A = 10;
            rightTriangle.B = 6;
            rightTriangle.C = 8;
            Assert.IsTrue(rightTriangle.IsRight());
        }
        ///<summary>
        ///Позитивный тест
        ///Треугольник прямоугольный
        ///гипотенуза - В
        ///<summary/>
        [TestMethod]
        public void IsRightTestB()
        {
            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.A = 3;
            rightTriangle.B = 5;
            rightTriangle.C = 4;
            Assert.IsTrue(rightTriangle.IsRight());
        }
        ///<summary>
        ///Позитивный тест
        ///Треугольник прямоугольный
        ///гипотенуза - С
        ///<summary/>
        [TestMethod]
        public void IsRightTestC()
        {
            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.A = 4;
            rightTriangle.B = 3;
            rightTriangle.C = 5;
            Assert.IsTrue(rightTriangle.IsRight());
        }


        ///<summary>
        ///Позитивный тест
        ///Вычисление периметра
        ///<summary/>
        [TestMethod]
        public void PerimetrTest()
        {
            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.A = 4;
            rightTriangle.B = 3;
            rightTriangle.C = 5;
            Assert.AreEqual(12, rightTriangle.Perimetr());
        }
        ///<summary>
        ///Позитивный тест
        ///Вычисление площади
        ///<summary/>
        [TestMethod]
        public void AreaTestA()
        {
            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.A = 5;
            rightTriangle.B = 4;
            rightTriangle.C = 3;
            Assert.AreEqual(6, rightTriangle.Area());
        }
        ///<summary>
        ///Позитивный тест
        ///Вычисление площади
        ///<summary/>
        [TestMethod]
        public void AreaTestB()
        {
            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.A = 4;
            rightTriangle.B = 5;
            rightTriangle.C = 3;
            Assert.AreEqual(6, rightTriangle.Area());
        }
        ///<summary>
        ///Позитивный тест
        ///Вычисление площади
        ///<summary/>
        [TestMethod]
        public void AreaTestC()
        {
            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.A = 3;
            rightTriangle.B = 4;
            rightTriangle.C = 5;
            Assert.AreEqual(6, rightTriangle.Area());
        }
    }
}
