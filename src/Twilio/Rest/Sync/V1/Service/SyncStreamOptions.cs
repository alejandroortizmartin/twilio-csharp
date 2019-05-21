/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Sync.V1.Service
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Fetch a specific Stream.
    /// </summary>
    public class FetchSyncStreamOptions : IOptions<SyncStreamResource>
    {
        /// <summary>
        /// Service Instance SID or unique name.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Stream SID or unique name.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchSyncStreamOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Instance SID or unique name. </param>
        /// <param name="pathSid"> Stream SID or unique name. </param>
        public FetchSyncStreamOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Delete a specific Stream.
    /// </summary>
    public class DeleteSyncStreamOptions : IOptions<SyncStreamResource>
    {
        /// <summary>
        /// Service Instance SID or unique name.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Stream SID or unique name.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteSyncStreamOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Instance SID or unique name. </param>
        /// <param name="pathSid"> Stream SID or unique name. </param>
        public DeleteSyncStreamOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Create a new Stream.
    /// </summary>
    public class CreateSyncStreamOptions : IOptions<SyncStreamResource>
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Stream unique name.
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// Stream TTL.
        /// </summary>
        public int? Ttl { get; set; }

        /// <summary>
        /// Construct a new CreateSyncStreamOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        public CreateSyncStreamOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Update a specific Stream.
    /// </summary>
    public class UpdateSyncStreamOptions : IOptions<SyncStreamResource>
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// Stream TTL.
        /// </summary>
        public int? Ttl { get; set; }

        /// <summary>
        /// Construct a new UpdateSyncStreamOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateSyncStreamOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Retrieve a list of all Streams in a Service Instance.
    /// </summary>
    public class ReadSyncStreamOptions : ReadOptions<SyncStreamResource>
    {
        /// <summary>
        /// Service Instance SID or unique name.
        /// </summary>
        public string PathServiceSid { get; }

        /// <summary>
        /// Construct a new ReadSyncStreamOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Instance SID or unique name. </param>
        public ReadSyncStreamOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}