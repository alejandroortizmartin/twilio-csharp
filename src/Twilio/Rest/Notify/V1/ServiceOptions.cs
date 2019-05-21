/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Notify.V1
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// CreateServiceOptions
    /// </summary>
    public class CreateServiceOptions : IOptions<ServiceResource>
    {
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The SID of the Credential to use for APN Bindings
        /// </summary>
        public string ApnCredentialSid { get; set; }
        /// <summary>
        /// The SID of the Credential to use for GCM Bindings
        /// </summary>
        public string GcmCredentialSid { get; set; }
        /// <summary>
        /// The SID of the Messaging Service to use for SMS Bindings
        /// </summary>
        public string MessagingServiceSid { get; set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        public string FacebookMessengerPageId { get; set; }
        /// <summary>
        /// The protocol version to use for sending APNS notifications
        /// </summary>
        public string DefaultApnNotificationProtocolVersion { get; set; }
        /// <summary>
        /// The protocol version to use for sending GCM notifications
        /// </summary>
        public string DefaultGcmNotificationProtocolVersion { get; set; }
        /// <summary>
        /// The SID of the Credential to use for FCM Bindings
        /// </summary>
        public string FcmCredentialSid { get; set; }
        /// <summary>
        /// The protocol version to use for sending FCM notifications
        /// </summary>
        public string DefaultFcmNotificationProtocolVersion { get; set; }
        /// <summary>
        /// Whether to log notifications
        /// </summary>
        public bool? LogEnabled { get; set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        public string AlexaSkillId { get; set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        public string DefaultAlexaNotificationProtocolVersion { get; set; }

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

            if (ApnCredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ApnCredentialSid", ApnCredentialSid.ToString()));
            }

            if (GcmCredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("GcmCredentialSid", GcmCredentialSid.ToString()));
            }

            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid.ToString()));
            }

            if (FacebookMessengerPageId != null)
            {
                p.Add(new KeyValuePair<string, string>("FacebookMessengerPageId", FacebookMessengerPageId));
            }

            if (DefaultApnNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultApnNotificationProtocolVersion", DefaultApnNotificationProtocolVersion));
            }

            if (DefaultGcmNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultGcmNotificationProtocolVersion", DefaultGcmNotificationProtocolVersion));
            }

            if (FcmCredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("FcmCredentialSid", FcmCredentialSid.ToString()));
            }

            if (DefaultFcmNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultFcmNotificationProtocolVersion", DefaultFcmNotificationProtocolVersion));
            }

            if (LogEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("LogEnabled", LogEnabled.Value.ToString().ToLower()));
            }

            if (AlexaSkillId != null)
            {
                p.Add(new KeyValuePair<string, string>("AlexaSkillId", AlexaSkillId));
            }

            if (DefaultAlexaNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultAlexaNotificationProtocolVersion", DefaultAlexaNotificationProtocolVersion));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// DeleteServiceOptions
    /// </summary>
    public class DeleteServiceOptions : IOptions<ServiceResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteServiceOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteServiceOptions(string pathSid)
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// FetchServiceOptions
    /// </summary>
    public class FetchServiceOptions : IOptions<ServiceResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchServiceOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchServiceOptions(string pathSid)
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// ReadServiceOptions
    /// </summary>
    public class ReadServiceOptions : ReadOptions<ServiceResource>
    {
        /// <summary>
        /// The string that identifies the Service resources to read
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// UpdateServiceOptions
    /// </summary>
    public class UpdateServiceOptions : IOptions<ServiceResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The SID of the Credential to use for APN Bindings
        /// </summary>
        public string ApnCredentialSid { get; set; }
        /// <summary>
        /// The SID of the Credential to use for GCM Bindings
        /// </summary>
        public string GcmCredentialSid { get; set; }
        /// <summary>
        /// The SID of the Messaging Service to use for SMS Bindings
        /// </summary>
        public string MessagingServiceSid { get; set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        public string FacebookMessengerPageId { get; set; }
        /// <summary>
        /// The protocol version to use for sending APNS notifications
        /// </summary>
        public string DefaultApnNotificationProtocolVersion { get; set; }
        /// <summary>
        /// The protocol version to use for sending GCM notifications
        /// </summary>
        public string DefaultGcmNotificationProtocolVersion { get; set; }
        /// <summary>
        /// The SID of the Credential to use for FCM Bindings
        /// </summary>
        public string FcmCredentialSid { get; set; }
        /// <summary>
        /// The protocol version to use for sending FCM notifications
        /// </summary>
        public string DefaultFcmNotificationProtocolVersion { get; set; }
        /// <summary>
        /// Whether to log notifications
        /// </summary>
        public bool? LogEnabled { get; set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        public string AlexaSkillId { get; set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        public string DefaultAlexaNotificationProtocolVersion { get; set; }

        /// <summary>
        /// Construct a new UpdateServiceOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public UpdateServiceOptions(string pathSid)
        {
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

            if (ApnCredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ApnCredentialSid", ApnCredentialSid.ToString()));
            }

            if (GcmCredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("GcmCredentialSid", GcmCredentialSid.ToString()));
            }

            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid.ToString()));
            }

            if (FacebookMessengerPageId != null)
            {
                p.Add(new KeyValuePair<string, string>("FacebookMessengerPageId", FacebookMessengerPageId));
            }

            if (DefaultApnNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultApnNotificationProtocolVersion", DefaultApnNotificationProtocolVersion));
            }

            if (DefaultGcmNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultGcmNotificationProtocolVersion", DefaultGcmNotificationProtocolVersion));
            }

            if (FcmCredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("FcmCredentialSid", FcmCredentialSid.ToString()));
            }

            if (DefaultFcmNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultFcmNotificationProtocolVersion", DefaultFcmNotificationProtocolVersion));
            }

            if (LogEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("LogEnabled", LogEnabled.Value.ToString().ToLower()));
            }

            if (AlexaSkillId != null)
            {
                p.Add(new KeyValuePair<string, string>("AlexaSkillId", AlexaSkillId));
            }

            if (DefaultAlexaNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultAlexaNotificationProtocolVersion", DefaultAlexaNotificationProtocolVersion));
            }

            return p;
        }
    }

}