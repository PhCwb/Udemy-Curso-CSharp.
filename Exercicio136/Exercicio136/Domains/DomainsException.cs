using System;

namespace Exercicio136.Domains
{
    internal class DomainsException : ApplicationException
    {
        public DomainsException (string message) : base(message)
        {
        }

    }
}
