using System;
using System.Collections.Generic;

namespace Polynomial
{
    public class Term
    {
        public int Power { get; set; }
        public double Coefficient { get; set; }

        public Term(int power=0, double coefficient = 0.0)
        {
            Power = power;
            Coefficient = coefficient;
        }

        public override string ToString()
        {
            return $"{Coefficient}x^{Power}";
        }
    }

    public class Polynomial
    {
        private LinkedList<Term> terms;

        public int Degree {
            // TODO:
            get
            {
                int degree = 0;
                foreach (var t in terms)
                {
                    if (t.Power > degree)
                    {
                        degree = t.Power;
                    }
                }

                return degree;
            }
        }

        public Polynomial()
        {
            terms = new LinkedList<Term>();
        }

        public void AddTerm( Term term)
        {
            // add a new term to the linked list of terms
            terms.AddLast(term);

            // simplify
            //Simplify();
        }

        // TODO
        private void Simplify()
        {
            // simplfy terms

            throw new NotImplementedException();
        }

        // TODO
        public static Polynomial Add(Polynomial p1, Polynomial p2)
        {
            // return p1 + p2

            throw new NotImplementedException();
        }

        // TODO
        public static Polynomial Subtract(Polynomial p1, Polynomial p2)
        {
            // return p1 - p2

            throw new NotImplementedException();
        }

        // TODO
        public static Polynomial Multiply(Polynomial p1, Polynomial p2)
        {
            // return p1 * p2

            throw new NotImplementedException();
        }

        public static Polynomial Negate(Polynomial polynomial)
        {
            // return -polynomial
            Polynomial negatedPolynomial = new Polynomial();

            foreach (var t in polynomial.terms)
            {
                negatedPolynomial.AddTerm(new Term(t.Power, -t.Coefficient) );
            }

            return negatedPolynomial;
        }

        public override string ToString()
        {
            string str = "";

            foreach(var t in terms)
            {
                str += t.Coefficient >= 0 ? " + " : " ";
                str += t;
                
            }

            return str;
        }


    }
}
