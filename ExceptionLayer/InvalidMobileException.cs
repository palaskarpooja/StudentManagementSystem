using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExceptionLayer
{
    public class InvalidMobileException : Exception
    {
        public InvalidMobileException(string message) : base(message)
        {
            
        }
    }
}
