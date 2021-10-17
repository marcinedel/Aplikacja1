using System;

namespace Aplikacja1.Matematyczne
{
    public class Mat
    {
        public double Dodawanie(double a, double b)
        {
            return a + b;
        }
        public double Odejmowanie(double a, double b)
        {
            return a - b;
        }

        //------------------------
        public float Dzielenie(int dzielna, int dzielnik)
        {
            if (dzielnik == 0) throw new DivideByZeroException();

            float result = (float)dzielna / dzielnik;
            Obliczono();
            return result;
        }

        public event EventHandler ZdarzenieObliczenia;

        protected virtual void Obliczono()
        {
            var handler = ZdarzenieObliczenia;
            if (handler != null) handler(this, EventArgs.Empty);
        }
        //--------------

        public double Mnożenie(double a, double b)
        {
            return a * b;
        }
        public Int32 WartoscBezwzgledna(int x)
        {
            int wynik;
            //oblicz wartosc bezwzgledna
            if (x < 0)
                wynik = -x;
            else
                wynik = x;

            //podaj wynik
            return wynik;
        }
        public int SumaCyfrLiczbyCalkowitej(int a)
        {
            int suma = 0;
            while (a > 0)
            {
                suma += a % 10;
                a /= 10;
            }
            return suma;
        }
        public double Wieksza(double a, double b)
        {
            return (a > b) ? a : b;
        }

        public ActionResult CzyParzysta(int n)
        {

            if (n % 2 == 0)
                return new Parzysta();

            return new Nieparzysta();
        }
        public class ActionResult { }
        public class Parzysta : ActionResult { }
        public class Nieparzysta : ActionResult { }


    }
}
