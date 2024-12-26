double x = 2.0;
double a = -1;
double b = 3.4;
double z = Math.Tan(b * x);
double y;
 if (x <= a)
 {
 y = Math.Exp(a * x) - 3.5 * Math.Pow(Math.Cos(z + b * x), 2);
 }
    else if (x > a && x <= Math.Pow(b, 3.5))
    {
        y = a + Math.Log(Math.Abs(a + b * x)) - 2 * x;
    }
    else
    {
        y = a + Math.Pow(Math.Cos(3.5), a + b * x * z);
    }

Console.WriteLine("Result: " + y);