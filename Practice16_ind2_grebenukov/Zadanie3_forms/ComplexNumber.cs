using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice15_Grebenukov
{
    class ComplexNumber
    {
        public double Real { get; set; } //Действительная часть
        public double Imaginary { get; set;} //Мнимая часть

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public string Add(ComplexNumber other) //Сложение комплексных чисел
        {
            double real = Real + other.Real;
            double imaginary = Imaginary + other.Imaginary;
            return $"{Math.Round(real, 2)} + {Math.Round(imaginary, 2)}i";
        }
        public string Subtract(ComplexNumber other) //Вычитание компелексных чисел
        {
            double real = Real - other.Real;
            double imaginary = Imaginary - other.Imaginary;

            return $"{Math.Round(real, 2)} + {Math.Round(imaginary, 2)}i";
        }
        public string Multiply(ComplexNumber other) //Умножение компексных чисел
        {
            double real = Real * other.Real - Imaginary * other.Imaginary;
            double imaginary = Real * other.Imaginary + Imaginary * other.Real;
            return $"{Math.Round(real, 2)} + {Math.Round(imaginary, 2)}i";
        }
    }
}
