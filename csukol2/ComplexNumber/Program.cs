using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class ComplexNumber
    {
        public double Real;
        public double Imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public void Add(ComplexNumber other)
        {
            return new ComplexNumber(Real + other.Real, Imaginary + other.Imaginary);
        }

        public void Substract(ComplexNumber other)
        {
            return new ComplexNumber(Real - other.Real, Imaginary - other.Imaginary)
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double real1 = double.Parse(Console.ReadLine()); // přečte všechny inputy
            double imaginary1 = double.Parse(Console.ReadLine());
            double real2 = double.Parse(Console.ReadLine());
            double imaginary2 = double.Parse(Console.ReadLine());

            ComplexNumber complex1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber complex2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber sum = complex1.Add(complex2);
            ComplexNumber difference = complex1.Subtract(complex2);

            Console.WriteLine("Součet " + sum.Real + " + " + sum.Imaginary);
            Console.WriteLine("Rozdíl " + difference.Real + " + " + difference.Imaginary);
        }
    }
}
