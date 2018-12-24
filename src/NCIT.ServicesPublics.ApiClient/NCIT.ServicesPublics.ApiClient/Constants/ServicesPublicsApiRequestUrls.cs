namespace NCIT.ServicesPublics.ApiClient.Constants
{
    internal static class ServicesPublicsApiRequestUrls
    {
        internal const string BaseRequestBaseUrl = "https://service-public.nc/api/{api_version}/";

        /// <summary>
        /// Base url for 'dossiers' endpoint.
        /// </summary>
        public static string DossiersRequestBaseUrl = BaseRequestBaseUrl + "dossiers";

        /// <summary>
        /// Base url for 'téléservices' endpoint.
        /// </summary>
        public static string TeleservicesRequestBaseUrl = BaseRequestBaseUrl + "teleservices";

        /// <summary>
        /// Base url for 'contacts' endpoint.
        /// </summary>
        public static string ContactsRequestBaseUrl = BaseRequestBaseUrl + "contacts";

        /// <summary>
        /// Base url for 'contacts' endpoint.
        /// </summary>
        public static string FaqsRequestBaseUrl = BaseRequestBaseUrl + "faqs";
    }
}
