using System;

namespace Pistoladas.Models.Exceptions
{
    public class EnvFileNotFoundException : ApplicationException
    {
        public EnvFileNotFoundException()
        {
        }
        public EnvFileNotFoundException(string message) : base(message)
        {
        }
    }
}
