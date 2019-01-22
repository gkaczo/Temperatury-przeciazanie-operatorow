using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatury
{
    class Temperatura
    {
        private double temperatura;
        
        public double TempCelsjusz
        {
            get
            {
                return temperatura;
            }
            set
            {
                temperatura = value;
            }
        }

        public double TempKelwin
        {
            set
            {
                temperatura = value - 273;
            }
        }

        public double TempFarenhait
        {
            set
            {
                temperatura = Math.Round(5*(value-32)/9,2);
            }
        }

        //przeciazanie operatorow

        public static Temperatura operator+(Temperatura t1,Temperatura t2)
        {
            Temperatura t = new Temperatura();
            t.temperatura=  t1.temperatura + t2.temperatura;

            return t;
        }

        public static Temperatura operator +(Temperatura t1, double t2)
        {
            Temperatura t = new Temperatura();
            t.temperatura = t1.temperatura + t2;

            return t;
        }


        //cwiczenie uczniowie
        public static Temperatura operator -(Temperatura t1, Temperatura t2)
        {
            Temperatura t = new Temperatura();
            t.temperatura = t1.temperatura - t2.temperatura;

            return t;
        }

        public static bool operator ==(Temperatura t1, Temperatura t2)
        {
            return t1.temperatura == t2.temperatura;

        }

        public static bool operator !=(Temperatura t1, Temperatura t2)
        {
            return t1.temperatura != t2.temperatura;
        }

        //podczas przeciążania operatorow == , != nalezy przesłonic
        //metody Equals i GetHashCode
        //== sprawdza czy referencja (obiekty są takie same (wartość typ)), Equals porównuje czy zawartość jest taka sama

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Temperatura))
                return false;
            else
                return this.temperatura == ((Temperatura)obj).temperatura;
        }

        // hash code jest wartością liczbową uzywana do identyfikacji obiektów
        //korzystajacych ze słownika lub klasy hashtable
        // hash code pozwala na efektywne porównywanie obiektów w kolekcjach

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
