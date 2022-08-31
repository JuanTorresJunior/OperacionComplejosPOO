using System;
using System.Collections.Generic;
using System.Text;

namespace OperacionComplejosPOO
{
    class Complejo
    {
        private double partReal, partImaginary;
        /// Complejo compoundResult = new Complejo();

        public double PartReal { get => partReal; set => partReal = value; }
        public double PartImaginary { get => partImaginary; set => partImaginary = value; }

        public Complejo()
        {
            partReal = 0;
            partImaginary = 0;
        }

        public Complejo(double partReal, double partImaginary)
        {
            this.partReal = partReal;
            this.partImaginary = partImaginary;
        }

        public override string ToString()
        {
            return $"Imaginary: { partImaginary }, Int: { partReal }";
        }

        /// Métodos

        public static Complejo operator +(Complejo i1, Complejo i2)
        {
            double e = 0;
            double i = 0;

            e = i1.partReal + i2.partReal;
            i = i1.partImaginary + i2.partImaginary;

            Complejo resultadoComplejo = new Complejo(e, i);
            return resultadoComplejo;
        }

        public static Complejo operator -(Complejo i1, Complejo i2)
        {
            double e = 0;
            double i = 0;

            e = i1.partReal - i2.partReal;
            i = i1.partImaginary - i2.partImaginary;

            Complejo resultadoComplejo = new Complejo(e, i);
            return resultadoComplejo;
        }

        public static Complejo operator *(Complejo i1, Complejo i2)
        {
            double e = 0;
            double i = 0;

            e = (i1.partReal * i2.partReal) - (i1.partImaginary * i2.partImaginary);
            i = (i1.partReal * i2.partImaginary) + (i1.partImaginary * i2.partReal);

            Complejo resultadoComplejo = new Complejo(e, i);
            return resultadoComplejo;
        }

        public static Complejo operator *(Complejo i1, double n)
        { 

            double e = i1.partReal * n;
            double i = i1.partImaginary * n;

            Complejo resultadoComplejo = new Complejo(e, i);
            return resultadoComplejo;
        }

        public static Complejo operator /(Complejo i1, Complejo i2)
        {
            double e = 0;
            double i = 0;

            e = ((i1.partReal * i2.partReal) / (Math.Pow(i2.partReal, 2) + Math.Pow(i2.partImaginary, 2)));
            i = (i1.partImaginary * i2.partReal - i1.partReal * i2.partImaginary) / ((Math.Pow(i2.partReal, 2) + Math.Pow(i2.partImaginary, 2)));

            Complejo resultadoComplejo = new Complejo(e, i);
            return resultadoComplejo;
        }
    }
}
