using System;

namespace NCIT.ServicesPublics.ApiClient.Exceptions
{
    [Serializable]
    public class InvalidApiVersionException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="InvalidApiVersionException"/>
        /// </summary>
        public InvalidApiVersionException() : base("Invalid Services Publics API version specified.")
        {
        }

        ///// <summary>
        ///// Initialize new instance of <see cref="InvalidApiVersionException"/>
        ///// </summary>
        ///// <param name="message">Exception message</param>
        //public InvalidApiVersionException(string message) : base(message)
        //{
        //}

        ///// <summary>
        ///// Initialize new instance of <see cref="InvalidApiVersionException"/>
        ///// </summary>
        ///// <param name="message">Exception message</param>
        ///// <param name="innerException">Inner exception</param>
        //public InvalidApiVersionException(string message, Exception innerException) : 
        //    base(message, innerException)
        //{
        //}
    }
}
