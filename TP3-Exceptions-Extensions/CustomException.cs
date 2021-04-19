using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Exceptions_Extensions
{
    public class CustomException : Exception
    {
        public CustomException() : base ("Debio ingresar un valor válido.")
        {

        }
    }
}
