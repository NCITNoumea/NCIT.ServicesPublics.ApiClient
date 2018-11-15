using System.Collections.Generic;

namespace NCIT.ServicesPublics.ApiClient.Constants
{
    public static class ServicesPublicsApiVersions
    {
        /// <summary>
        /// Default api version : v1.0
        /// </summary>
        public static readonly string DEFAULT = "v1.0";

        /// <summary>
        /// Api version v1.0
        /// </summary>
        public static readonly string V1_0 = "v1.0";

        /// <summary>
        /// Check if given version is a valid FB api version or not
        /// </summary>
        /// <param name="version">API version to check</param>
        /// <returns>True if api version is valid</returns>
        public static bool IsValidVersion(string version)
        {
            var validVersions = new List<string>() { V1_0 };
            return validVersions.Contains(version);
        }
    }
}