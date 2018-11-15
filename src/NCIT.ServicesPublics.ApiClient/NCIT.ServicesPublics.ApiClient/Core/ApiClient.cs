using NCIT.ServicesPublics.ApiClient.Constants;
using NCIT.ServicesPublics.ApiClient.Exceptions;

namespace NCIT.ServicesPublics.ApiClient.Core
{
    public class ApiClient
    {
        /// <summary>
        /// An access token is an opaque string that identifies a user, app.
        /// </summary>
        public string AccessToken { get; private set; }

        /// <summary>
        /// Api version to use while making api calls
        /// </summary>
        public string Version { get; private set; }

        /// <summary>
        /// Create new instance of <see cref="ApiClient"/> using given <see cref="AccessToken"/>
        /// </summary>
        /// <param name="accessToken">Access token</param>
        public ApiClient(string accessToken)
        {
            SetAccessToken(accessToken);
            SetApiVersion(ServicesPublicsApiVersions.DEFAULT);
        }

        /// <summary>
        /// Create new instance of <see cref="ApiClient"/> using given <see cref="AccessToken"/> &amp; <see cref="Version"/>
        /// </summary>
        /// <param name="accessToken"><see cref="AccessToken"/></param>
        /// <param name="version"><see cref="Version"/></param>
        public ApiClient(string accessToken, string version)
        {
            SetApiVersion(version);
            SetAccessToken(accessToken);
        }

        private void SetApiVersion(string version)
        {
            if (ServicesPublicsApiVersions.IsValidVersion(version))
            {
                Version = version;
            }
            else
            {
                throw new InvalidApiVersionException();
            }
        }

        private void SetAccessToken(string accessToken)
        {
            AccessToken = accessToken;
        }
    }
}