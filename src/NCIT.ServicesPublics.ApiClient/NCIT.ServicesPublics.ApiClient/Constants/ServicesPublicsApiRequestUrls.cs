namespace NCIT.ServicesPublics.ApiClient.Constants
{
    internal static class ServicesPublicsApiRequestUrls
    {
        internal const string BASE_REQUEST_BASE_URL = "https://service-public.nc/api/{api_version}/";

        /// <summary>
        /// Base url for 'dossiers' endpoint.
        /// </summary>
        public static string DOSSIERS_REQUEST_BASE_URL = BASE_REQUEST_BASE_URL + "dossiers";

        /// <summary>
        /// Base url for 'téléservices' endpoint.
        /// </summary>
        public static string TELESERVICES_REQUEST_BASE_URL = BASE_REQUEST_BASE_URL + "teleservices";

        /// <summary>
        /// Base url for 'contacts' endpoint.
        /// </summary>
        public static string CONTACTS_REQUEST_BASE_URL = BASE_REQUEST_BASE_URL + "contacts";

        /// <summary>
        /// Base url for 'contacts' endpoint.
        /// </summary>
        public static string FAQS_REQUEST_BASE_URL = BASE_REQUEST_BASE_URL + "faqs";
    }
}
