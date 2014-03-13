using System;


namespace Float_or_Double
{
    class FloatOrDouble
    {
        static void Main()
        {
            float numeroUno = 12.345f;
            float numeroDos = 3456.091f;
            double numeroTres = 8923.1234857;
            double numeroQuatro = 34.567839023;
            Console.WriteLine("The first number is type float {0}, the second one is type float {1},\r\nthird number is double {2} and last one is also type double \r\n{3}", numeroUno, numeroDos, numeroTres, numeroQuatro);


            Console.WriteLine(Double.MaxValue);
        }
    }
}
