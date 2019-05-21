/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// DependentPhoneNumberResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Address
{

    public class DependentPhoneNumberResource : Resource
    {
        public sealed class AddressRequirementEnum : StringEnum
        {
            private AddressRequirementEnum(string value) : base(value) {}
            public AddressRequirementEnum() {}
            public static implicit operator AddressRequirementEnum(string value)
            {
                return new AddressRequirementEnum(value);
            }

            public static readonly AddressRequirementEnum None = new AddressRequirementEnum("none");
            public static readonly AddressRequirementEnum Any = new AddressRequirementEnum("any");
            public static readonly AddressRequirementEnum Local = new AddressRequirementEnum("local");
            public static readonly AddressRequirementEnum Foreign = new AddressRequirementEnum("foreign");
        }

        public sealed class EmergencyStatusEnum : StringEnum
        {
            private EmergencyStatusEnum(string value) : base(value) {}
            public EmergencyStatusEnum() {}
            public static implicit operator EmergencyStatusEnum(string value)
            {
                return new EmergencyStatusEnum(value);
            }

            public static readonly EmergencyStatusEnum Active = new EmergencyStatusEnum("Active");
            public static readonly EmergencyStatusEnum Inactive = new EmergencyStatusEnum("Inactive");
        }

        private static Request BuildReadRequest(ReadDependentPhoneNumberOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Addresses/" + options.PathAddressSid + "/DependentPhoneNumbers.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read DependentPhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DependentPhoneNumber </returns>
        public static ResourceSet<DependentPhoneNumberResource> Read(ReadDependentPhoneNumberOptions options,
                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<DependentPhoneNumberResource>.FromJson("dependent_phone_numbers", response.Content);
            return new ResourceSet<DependentPhoneNumberResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read DependentPhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DependentPhoneNumber </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DependentPhoneNumberResource>> ReadAsync(ReadDependentPhoneNumberOptions options,
                                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<DependentPhoneNumberResource>.FromJson("dependent_phone_numbers", response.Content);
            return new ResourceSet<DependentPhoneNumberResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathAddressSid"> The SID of the Address resource associated with the phone number </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DependentPhoneNumber </returns>
        public static ResourceSet<DependentPhoneNumberResource> Read(string pathAddressSid,
                                                                     string pathAccountSid = null,
                                                                     int? pageSize = null,
                                                                     long? limit = null,
                                                                     ITwilioRestClient client = null)
        {
            var options = new ReadDependentPhoneNumberOptions(pathAddressSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathAddressSid"> The SID of the Address resource associated with the phone number </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DependentPhoneNumber </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DependentPhoneNumberResource>> ReadAsync(string pathAddressSid,
                                                                                                             string pathAccountSid = null,
                                                                                                             int? pageSize = null,
                                                                                                             long? limit = null,
                                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadDependentPhoneNumberOptions(pathAddressSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<DependentPhoneNumberResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<DependentPhoneNumberResource>.FromJson("dependent_phone_numbers", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<DependentPhoneNumberResource> NextPage(Page<DependentPhoneNumberResource> page,
                                                                  ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<DependentPhoneNumberResource>.FromJson("dependent_phone_numbers", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<DependentPhoneNumberResource> PreviousPage(Page<DependentPhoneNumberResource> page,
                                                                      ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<DependentPhoneNumberResource>.FromJson("dependent_phone_numbers", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a DependentPhoneNumberResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DependentPhoneNumberResource object represented by the provided JSON </returns>
        public static DependentPhoneNumberResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<DependentPhoneNumberResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        [JsonProperty("friendly_name")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber FriendlyName { get; private set; }
        /// <summary>
        /// The phone number in E.164 format
        /// </summary>
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }
        /// <summary>
        /// The URL we call when the phone number receives a call
        /// </summary>
        [JsonProperty("voice_url")]
        public Uri VoiceUrl { get; private set; }
        /// <summary>
        /// The HTTP method used with the voice_url
        /// </summary>
        [JsonProperty("voice_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceMethod { get; private set; }
        /// <summary>
        /// The HTTP method used with voice_fallback_url
        /// </summary>
        [JsonProperty("voice_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; private set; }
        /// <summary>
        /// The URL we call when an error occurs in TwiML
        /// </summary>
        [JsonProperty("voice_fallback_url")]
        public Uri VoiceFallbackUrl { get; private set; }
        /// <summary>
        /// Whether to lookup the caller's name
        /// </summary>
        [JsonProperty("voice_caller_id_lookup")]
        public bool? VoiceCallerIdLookup { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The HTTP method used with sms_fallback_url
        /// </summary>
        [JsonProperty("sms_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; private set; }
        /// <summary>
        /// The URL that we call when an error occurs while retrieving or executing the TwiML
        /// </summary>
        [JsonProperty("sms_fallback_url")]
        public Uri SmsFallbackUrl { get; private set; }
        /// <summary>
        /// The HTTP method to use with sms_url
        /// </summary>
        [JsonProperty("sms_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod SmsMethod { get; private set; }
        /// <summary>
        /// The URL we call when the phone number receives an incoming SMS message
        /// </summary>
        [JsonProperty("sms_url")]
        public Uri SmsUrl { get; private set; }
        /// <summary>
        /// Whether the phone number requires an Address registered with Twilio
        /// </summary>
        [JsonProperty("address_requirements")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DependentPhoneNumberResource.AddressRequirementEnum AddressRequirements { get; private set; }
        /// <summary>
        /// Indicate if a phone can receive calls or messages
        /// </summary>
        [JsonProperty("capabilities")]
        public object Capabilities { get; private set; }
        /// <summary>
        /// The URL to send status information to your application
        /// </summary>
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }
        /// <summary>
        /// The HTTP method we use to call status_callback
        /// </summary>
        [JsonProperty("status_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; private set; }
        /// <summary>
        /// The API version used to start a new TwiML session
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The SID of the application that handles SMS messages sent to the phone number
        /// </summary>
        [JsonProperty("sms_application_sid")]
        public string SmsApplicationSid { get; private set; }
        /// <summary>
        /// The SID of the application that handles calls to the phone number
        /// </summary>
        [JsonProperty("voice_application_sid")]
        public string VoiceApplicationSid { get; private set; }
        /// <summary>
        /// The SID of the Trunk that handles calls to the phone number
        /// </summary>
        [JsonProperty("trunk_sid")]
        public string TrunkSid { get; private set; }
        /// <summary>
        /// Whether the phone number is enabled for emergency calling
        /// </summary>
        [JsonProperty("emergency_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DependentPhoneNumberResource.EmergencyStatusEnum EmergencyStatus { get; private set; }
        /// <summary>
        /// The emergency address configuration to use for emergency calling
        /// </summary>
        [JsonProperty("emergency_address_sid")]
        public string EmergencyAddressSid { get; private set; }
        /// <summary>
        /// The URI of the resource, relative to `https://api.twilio.com`
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }

        private DependentPhoneNumberResource()
        {

        }
    }

}