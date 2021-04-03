using System;

namespace Pistoladas.Models.Exceptions.User
{
    public class UserNotFoundException : ApplicationException
    {
        public UserNotFoundException()
        {
        }

        public UserNotFoundException(string message) : base(message)
        {
        }
    }
}