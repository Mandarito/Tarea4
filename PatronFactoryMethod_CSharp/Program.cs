using System;

namespace PatronFactoryMethod_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicios = Crear.CrearEjercicio(Crear.Flexiones);
            Console.WriteLine(ejercicios.CaloriasXHora());
            Ejercicios ejercicios1 = Crear.CrearEjercicio(Crear.Sentadillas);
            Console.WriteLine(ejercicios1.CaloriasXHora());
        }
    }
}
