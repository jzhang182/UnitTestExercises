using System;
using Xunit;

namespace XUnitTestSortByParity
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 0 });
            Assert.Equal(new int[]{ 0 },result);
        }
    }
    public class UnitTest2
    {
        [Fact]
        public void Test2()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 1 });
            Assert.Equal(new int[] { 1 }, result);
        }
    }
    public class UnitTest3
    {
        [Fact]
        public void Test3()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 0, 0 });
            Assert.Equal(new int[] { 0, 0 }, result);
        }
    }
    public class UnitTest4
    {
        [Fact]
        public void Test4()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 0, 1 });
            Assert.Equal(new int[] { 0, 1 }, result);
        }
    }
    public class UnitTest5
    {
        [Fact]
        public void Test5()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 1, 1 });
            Assert.Equal(new int[] { 1, 1 }, result);
        }
    }
    public class UnitTest6
    {
        [Fact]
        public void Test6()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 2, 4, 1, 3 });
            Assert.Equal(new int[] { 2, 4, 1, 3 }, result);
        }
    }
    public class UnitTest7
    {
        [Fact]
        public void Test7()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 1, 3, 2, 4 });
            Assert.Equal(new int[] { 2, 4, 1, 3 }, result);
        }
    }
    public class UnitTest8
    {
        [Fact]
        public void Test8()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 2, 2, 2, 10 });
            Assert.Equal(new int[] { 2, 2, 2, 10 }, result);
        }
    }
    public class UnitTest9
    {
        [Fact]
        public void Test9()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 10, 2, 2, 6 });
            Assert.Equal(new int[] { 2, 2, 6, 10 }, result);
        }
    }
    public class UnitTest10
    {
        [Fact]
        public void Test10()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 1, 1, 1, 9 });
            Assert.Equal(new int[] { 1, 1, 1, 9 }, result);
        }
    }
    public class UnitTest11
    {
        [Fact]
        public void Test11()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 1, 9, 7, 1 });
            Assert.Equal(new int[] { 1, 1, 7, 9 }, result);
        }
    }
    public class UnitTest12
    {
        [Fact]
        public void Test12()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 2, 7, 5, 10, 100, 3, 11, 17, 8, 9, 52 });
            Assert.Equal(new int[] { 2, 8, 10, 52, 100, 3, 5, 7, 9, 11, 17 }, result);
        }
    }
    public class UnitTest13
    {
        [Fact]
        public void Test13()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 2, 7, 10, 5, 8, 11, 52, 3, 12, 17, 16, 9 });
            Assert.Equal(new int[] { 2, 8, 10, 12, 16, 52, 3, 5, 7, 9, 11, 17 }, result);
        }
    }
    public class UnitTest14
    {
        [Fact]
        public void Test14()
        {
            var algorithm = new ParitySortAlgorithm();
            int[] result = algorithm.SortByParity(new int[] { 2, 8, 10, 12, 16, 52, 3, 5, 7, 9, 11, 17 });
            Assert.Equal(new int[] { 2, 8, 10, 12, 16, 52, 3, 5, 7, 9, 11, 17 }, result);
        }
    }
}
