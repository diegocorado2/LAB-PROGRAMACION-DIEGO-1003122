using System;
using System.Collections.Generic;
using System.Text;

namespace T10_DECG_1003122
{
    class CIRCULO
    {
        private double radio;
        private double ObtenerPerimetro;
        private double ObtenerArea;
        private double ObtenerVolumen;
        public double CalcularGeometria;



        public CIRCULO(double radio_)
        {
            radio = radio_;

        }

        private double CalcularPerimetro()
        {
            double RESULTADOPERIMETRO = 2 * Math.PI * radio;
            return RESULTADOPERIMETRO;

        }

        public double getperimetro()
        {
            return CalcularPerimetro();

        }

        private double calculararea()
        {
            double RESULTADOAREA = Math.PI * Math.Pow(radio, 2);
            return RESULTADOAREA;
        }

        public double getarea()
        {
            return calculararea();
        }

        private double calcularvolumen()
        {
            double RESULTADOVOLUMEN = 4 * Math.PI * Math.Pow(radio, 3) % 3;
            return RESULTADOVOLUMEN;
        }

        public double getvolumen()
        {
            return calcularvolumen();
        }
    }

}
