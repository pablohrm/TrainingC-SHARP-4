using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_Excecao.Entities.Exceptions;

namespace Exercicio_Excecao.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
