
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronSingleton_CSharp
{
    class Singleton
    {
        private static Singleton instance = null;
        public string mensaje = "";
         

        
        private Singleton() 
        {
            mensaje = "Buenas Profesor Kelyn Tejada";
        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        
    }
}
