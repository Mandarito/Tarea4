using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactoryMethod_CSharp
{
   public  class Crear
    {
        public const int Sentadillas = 1;
        public const int Flexiones = 2;
        public static Ejercicios CrearEjercicio(int Tipo)
        {
            switch (Tipo)
            {
                case Sentadillas:
                    return new Sentadillas();
                case Flexiones:
                    return new Flexiones();
                default:
                    return null;
            }

        }
    }

}
