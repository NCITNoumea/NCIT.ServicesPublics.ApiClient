using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace NCIT.ServicesPublics.ApiClient.Exceptions
{
    /// <summary>
    /// Represents error in SDK while deserializing API response.
    /// </summary>
    [Serializable]
    internal class SdkException : Exception
    {
        /// <summary>
        /// Content of api responce as string
        /// </summary>
        public string ApiResponseContent { get; }

        /// <summary>
        /// Initialize new instance of <see cref="SdkException"/>
        /// </summary>
        /// <param name="apiResponseContent">Content of api responce as string</param>
        /// <param name="ex">Exception</param>
        public SdkException(string apiResponseContent, Exception ex) : base(ex.Message, ex)
        {
            ApiResponseContent = apiResponseContent;
        }

        /// <summary>
        /// Populates a SerializationInfo with the data needed to serialize the target object.
        /// </summary>
        /// <param name="info">The SerializationInfo to populate with data.</param>
        /// <param name="context">The destination for this serialization.</param>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));

            info.AddValue("ApiResponseContent", ApiResponseContent);

            base.GetObjectData(info, context);
        }
    }
}
