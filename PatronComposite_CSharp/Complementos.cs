using System;
using System.Collections.Generic;
using System.Text;

namespace PatronComposite_CSharp
{
    class Complementos : Composite
    {
        public int Cantidad { get; set; }
        public string slot { get; set; }
        public Complementos(string Nombre, decimal Precio, string slot) : base(Nombre, Precio)
        {
            this.Cantidad = Cantidad;
            this.slot = slot;
        }
    }
}
