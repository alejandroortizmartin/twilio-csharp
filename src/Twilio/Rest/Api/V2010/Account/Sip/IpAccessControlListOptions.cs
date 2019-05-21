/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Sip
{

    /// <summary>
    /// Retrieve a list of IpAccessControlLists that belong to the account used to make the request
    /// </summary>
    public class ReadIpAccessControlListOptions : ReadOptions<IpAccessControlListResource>
    {
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        public string PathAccountSid { get; set; }

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

    /// <summary>
    /// Create a new IpAccessControlList resource
    /// </summary>
    public class CreateIpAccessControlListOptions : IOptions<IpAccessControlListResource>
    {
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        public string FriendlyName { get; }

        /// <summary>
        /// Construct a new CreateIpAccessControlListOptions
        /// </summary>
        /// <param name="friendlyName"> A human readable description of this resource </param>
        public CreateIpAccessControlListOptions(string friendlyName)
        {
            FriendlyName = friendlyName;
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

            return p;
        }
    }

    /// <summary>
    /// Fetch a specific instance of an IpAccessControlList
    /// </summary>
    public class FetchIpAccessControlListOptions : IOptions<IpAccessControlListResource>
    {
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// A string that identifies the resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchIpAccessControlListOptions
        /// </summary>
        /// <param name="pathSid"> A string that identifies the resource to fetch </param>
        public FetchIpAccessControlListOptions(string pathSid)
        {
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
    /// Rename an IpAccessControlList
    /// </summary>
    public class UpdateIpAccessControlListOptions : IOptions<IpAccessControlListResource>
    {
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// A string that identifies the resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        public string FriendlyName { get; }

        /// <summary>
        /// Construct a new UpdateIpAccessControlListOptions
        /// </summary>
        /// <param name="pathSid"> A string that identifies the resource to update </param>
        /// <param name="friendlyName"> A human readable description of this resource </param>
        public UpdateIpAccessControlListOptions(string pathSid, string friendlyName)
        {
            PathSid = pathSid;
            FriendlyName = friendlyName;
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

            return p;
        }
    }

    /// <summary>
    /// Delete an IpAccessControlList from the requested account
    /// </summary>
    public class DeleteIpAccessControlListOptions : IOptions<IpAccessControlListResource>
    {
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// A string that identifies the resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteIpAccessControlListOptions
        /// </summary>
        /// <param name="pathSid"> A string that identifies the resource to delete </param>
        public DeleteIpAccessControlListOptions(string pathSid)
        {
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

}