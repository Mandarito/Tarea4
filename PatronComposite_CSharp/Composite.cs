using System;
using System.Collections.Generic;
using System.Text;

namespace PatronComposite_CSharp
{
   abstract class Composite
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Composite(string Nombre, decimal Precio)
        {
            this.Nombre = Nombre;
            this.Precio = Precio;
        }
    }
}
