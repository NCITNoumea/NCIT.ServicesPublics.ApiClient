using System;
using System.Collections.Generic;
using System.Linq;
using NCIT.ServicesPublics.ApiClient.Constants;
using NCIT.ServicesPublics.ApiClient.Core.Interfaces;
using RestSharp;

namespace NCIT.ServicesPublics.ApiClient.Core
{
    /// <summary>
    /// Represents response received from API.
    /// </summary>
    /// <typeparam name="TEntity">Entity class which can be used to represent received API response</typeparam>
    public class ApiResponse<TEntity> : IResponse<TEntity> where TEntity : class
    {
        /// <summary>
        /// Api result in format of TEntity 
        /// </summary>
        private readonly TEntity _result;

        /// <summary>
        /// List of exceptions from api response
        /// </summary>
        private readonly IEnumerable<Exception> _exceptions;

        /// <summary>
        /// ETag response header value
        /// </summary>
        public string ETag { get; private set; }

        /// <summary>
        /// Initialize instance of <see cref="ApiResponse{TEntity}"/>
        /// </summary>
        /// <param name="response">Api Response of type TEntity</param>
        /// <param name="headerParameters">Response headers</param>
        /// <param name="exceptions">API response exceptions</param>
        public ApiResponse(TEntity response, IList<Parameter> headerParameters, IEnumerable<Exception> exceptions)
        {
            _result = response;
            _exceptions = exceptions;
            SetValuesFromResponceHeaders(headerParameters);
        }

        private void SetValuesFromResponceHeaders(IList<Parameter> headerParameters)
        {
            var tempParameter = headerParameters.FirstOrDefault(e => e.Name.Equals(ServicesPublicsApiResponseHeaders.Etag));
            if (tempParameter != null)
                ETag = tempParameter.Value.ToString();
        }

        /// <inheritdoc />
        public TEntity GetResult()
        {
            return _result;
        }

        /// <inheritdoc />
        public IEnumerable<Exception> GetExceptions()
        {
            return _exceptions;
        }
    }
}