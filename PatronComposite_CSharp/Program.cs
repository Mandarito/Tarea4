using System;

namespace PatronComposite_CSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Complementos complementos = new Complementos("Procesador", 12900, "21");
            Complementos complementos2 = new Complementos("RAM", 1300, "50");
            Complementos complementos3 = new Complementos("Tarjeta Madre", 8000, "21");
            Complementos complementos4 = new Complementos("SSD", 23900, "150");
            FinalComposite finalComposite = new FinalComposite("PC");
            finalComposite.Add(complementos);
            finalComposite.Add(complementos2);
            finalComposite.Add(complementos3);
            finalComposite.Add(complementos4);
            Console.WriteLine(finalComposite.Precio);


        }
    }
}
