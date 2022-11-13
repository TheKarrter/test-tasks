using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    internal class ShapeArea
    {
double TriangleArea(int a, int b, int c){


if((a + b > c)&(a + c > b)&(c + b > a)){

double p = (a + b + c)/2;
double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
Console.WriteLine("Площадь треугольника: " + S);
return S;
}
else Console.WriteLine("Такого треугольника не существует!");
return a&b&c;
}

double RoundArea(int r){
    double S = Math.PI * r*r;
    System.Console.WriteLine("Площадь круга: ", S);
    return S;
}
    }
}
