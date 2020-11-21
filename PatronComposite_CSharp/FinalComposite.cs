using System;
using System.Collections.Generic;
using System.Text;

namespace PatronComposite_CSharp
{
    class FinalComposite : Composite
    {
        private List<Composite> com = new List<Composite>();
        public decimal Precio
        {
            get
            {
                decimal precio = 0;
                foreach(var oObject in com)
                {
                    precio += oObject.Precio;
                }
                return precio;
            }
        }
        public void Add(Composite oObjeto)
        {
            com.Add(oObjeto);
        }
        public void Remove(Composite oObjeto)
        {
            com.Remove(oObjeto);
        }
        public FinalComposite(string Nombre, decimal Precio=0) : base(Nombre, Precio)
        {
        }
    }
}
