using System;

namespace Polynomial
{
    class Program
    {
        static void Main(string[] args)
        {

            Polynomial polynomial = new Polynomial();

            polynomial.AddTerm(new Term(7, -42));
            polynomial.AddTerm(new Term(2, 4));
            polynomial.AddTerm(new Term(2, 5));
            polynomial.AddTerm(new Term(1, -6.8));
            polynomial.AddTerm(new Term(0, -17));

            Console.WriteLine(polynomial.Degree);
            Console.WriteLine(polynomial);
        }
    }
}
