using System;

namespace GildedRoseKata.Infrastructure.Exceptions
{
    public class ServiceException : Exception
    {
        public ServiceException(string message, string target) : base(message)
        {
            Target = target;
        }

        public string Target { get; protected set; }
    }
}