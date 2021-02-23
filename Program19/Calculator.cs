using System;

namespace MathFunction
{
    class Calculator
    {
        //NOTE: Visual Studio allows optional parameters only on static types.

        //This is acceptable: public static void Schedule(int courseId = 1)
        //This is not acceptable: public static void Schedule(Course course = New Course())

        public static int Add(int x, int y = 0) => x + y;
        public static int Add(int x, int y, int z = 0, int u = 0, int v = 0, int w = 0) => x + y + z + u + v + w;
        public static int Sub(int x, int y = 0) => x - y;
        public static int Mul(int x, int y = 1) => x * y;
        public static int Div(int x, int y = 1) => x / y;

        //Output parameters are declared in a method signature with the out keyword.
        //It is better to use a return value if only one return value.
        public static void FourFunction(int x, int y, out int add, out int sub, out int mul, out int div)
        {
            add = x + y;
            sub = x - y;
            mul = x * y;

            if (y == 0)
            {
                div = x / 1;
            }
            else
            {
                div = x / y;
            }
        }
    }
}
