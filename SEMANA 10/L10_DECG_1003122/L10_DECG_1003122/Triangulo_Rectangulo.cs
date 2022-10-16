using System;
using System.Collections.Generic;
using System.Text;

namespace L10_DECG_1003122
{
    class Triangulo_Rectangulo
    {
        public double catetoA;
        public double anguloOpuestoA;

        public double ObtenerCatetoB()
        {
            return catetoA / Math.Tan(anguloOpuestoA);
        }

        public double ObtenerHipotenusa()
        {
            return catetoA / Math.Sin(anguloOpuestoA);
        }

        public double ObtenerAnguloOpuestoB()
        {
            return 90 - anguloOpuestoA;
        }

        public double ObtenerArea()
        {
            return catetoA * ObtenerCatetoB();
        }

    }
}
