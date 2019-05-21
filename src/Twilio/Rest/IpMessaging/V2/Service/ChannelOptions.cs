/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.IpMessaging.V2.Service
{

    /// <summary>
    /// FetchChannelOptions
    /// </summary>
    public class FetchChannelOptions : IOptions<ChannelResource>
    {
        /// <summary>
        /// The SID of the Service to fetch the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchChannelOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the resource from </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchChannelOptions(string pathServiceSid, string pathSid)
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
    /// DeleteChannelOptions
    /// </summary>
    public class DeleteChannelOptions : IOptions<ChannelResource>
    {
        /// <summary>
        /// The SID of the Service to delete the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteChannelOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the resource from </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteChannelOptions(string pathServiceSid, string pathSid)
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
    /// CreateChannelOptions
    /// </summary>
    public class CreateChannelOptions : IOptions<ChannelResource>
    {
        /// <summary>
        /// The SID of the Service to create the resource under
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// A string to describe the new resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// An application-defined string that uniquely identifies the resource
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// A valid JSON string that contains application-specific data
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The visibility of the channel
        /// </summary>
        public ChannelResource.ChannelTypeEnum Type { get; set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was updated
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// The identity of the User that created the Channel
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Construct a new CreateChannelOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the resource under </param>
        public CreateChannelOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (CreatedBy != null)
            {
                p.Add(new KeyValuePair<string, string>("CreatedBy", CreatedBy));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadChannelOptions
    /// </summary>
    public class ReadChannelOptions : ReadOptions<ChannelResource>
    {
        /// <summary>
        /// The SID of the Service to read the resources from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The visibility of the channel to read
        /// </summary>
        public List<ChannelResource.ChannelTypeEnum> Type { get; set; }

        /// <summary>
        /// Construct a new ReadChannelOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the resources from </param>
        public ReadChannelOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
            Type = new List<ChannelResource.ChannelTypeEnum>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Type != null)
            {
                p.AddRange(Type.Select(prop => new KeyValuePair<string, string>("Type", prop.ToString())));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateChannelOptions
    /// </summary>
    public class UpdateChannelOptions : IOptions<ChannelResource>
    {
        /// <summary>
        /// The SID of the Service to update the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// An application-defined string that uniquely identifies the resource
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// A valid JSON string that contains application-specific data
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was updated
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// The identity of the User that created the Channel
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Construct a new UpdateChannelOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to update the resource from </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public UpdateChannelOptions(string pathServiceSid, string pathSid)
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
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (CreatedBy != null)
            {
                p.Add(new KeyValuePair<string, string>("CreatedBy", CreatedBy));
            }

            return p;
        }
    }

}