using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14_Entidades
{
    public class ErrorParserException : Exception
    {
        public ErrorParserException() : base()
        {

        }

        public ErrorParserException(string message) : base(message)
        {

        }

        public ErrorParserException(string message, Exception inner) : base(message, inner)
        {

        }

        public override string Message => base.Message;
    }
}
