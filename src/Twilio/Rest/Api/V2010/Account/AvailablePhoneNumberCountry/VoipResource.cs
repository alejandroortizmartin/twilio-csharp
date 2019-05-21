/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// VoipResource
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

namespace Twilio.Rest.Api.V2010.Account.AvailablePhoneNumberCountry
{

    public class VoipResource : Resource
    {
        private static Request BuildReadRequest(ReadVoipOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/AvailablePhoneNumbers/" + options.PathCountryCode + "/Voip.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Voip parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Voip </returns>
        public static ResourceSet<VoipResource> Read(ReadVoipOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<VoipResource>.FromJson("available_phone_numbers", response.Content);
            return new ResourceSet<VoipResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Voip parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Voip </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<VoipResource>> ReadAsync(ReadVoipOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<VoipResource>.FromJson("available_phone_numbers", response.Content);
            return new ResourceSet<VoipResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathCountryCode"> The ISO Country code of the country from which to read phone numbers </param>
        /// <param name="pathAccountSid"> The SID of the Account requesting the AvailablePhoneNumber resources </param>
        /// <param name="areaCode"> The area code of the phone numbers to read </param>
        /// <param name="contains"> The pattern on which to match phone numbers </param>
        /// <param name="smsEnabled"> Whether the phone numbers can receive text messages </param>
        /// <param name="mmsEnabled"> Whether the phone numbers can receive MMS messages </param>
        /// <param name="voiceEnabled"> Whether the phone numbers can receive calls. </param>
        /// <param name="excludeAllAddressRequired"> Whether to exclude phone numbers that require an Address </param>
        /// <param name="excludeLocalAddressRequired"> Whether to exclude phone numbers that require a local address </param>
        /// <param name="excludeForeignAddressRequired"> Whether to exclude phone numbers that require a foreign address
        ///                                     </param>
        /// <param name="beta"> Whether to read phone numbers new to the Twilio platform </param>
        /// <param name="nearNumber"> Given a phone number, find a geographically close number within distance miles.
        ///                  (US/Canada only) </param>
        /// <param name="nearLatLong"> Given a latitude/longitude pair lat,long find geographically close numbers within
        ///                   distance miles. (US/Canada only) </param>
        /// <param name="distance"> The search radius, in miles, for a near_ query. (US/Canada only) </param>
        /// <param name="inPostalCode"> Limit results to a particular postal code. (US/Canada only) </param>
        /// <param name="inRegion"> Limit results to a particular region. (US/Canada only) </param>
        /// <param name="inRateCenter"> Limit results to a specific rate center, or given a phone number search within the same
        ///                    rate center as that number. (US/Canada only) </param>
        /// <param name="inLata"> Limit results to a specific local access and transport area. (US/Canada only) </param>
        /// <param name="inLocality"> Limit results to a particular locality </param>
        /// <param name="faxEnabled"> Whether the phone numbers can receive faxes </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Voip </returns>
        public static ResourceSet<VoipResource> Read(string pathCountryCode,
                                                     string pathAccountSid = null,
                                                     int? areaCode = null,
                                                     string contains = null,
                                                     bool? smsEnabled = null,
                                                     bool? mmsEnabled = null,
                                                     bool? voiceEnabled = null,
                                                     bool? excludeAllAddressRequired = null,
                                                     bool? excludeLocalAddressRequired = null,
                                                     bool? excludeForeignAddressRequired = null,
                                                     bool? beta = null,
                                                     Types.PhoneNumber nearNumber = null,
                                                     string nearLatLong = null,
                                                     int? distance = null,
                                                     string inPostalCode = null,
                                                     string inRegion = null,
                                                     string inRateCenter = null,
                                                     string inLata = null,
                                                     string inLocality = null,
                                                     bool? faxEnabled = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadVoipOptions(pathCountryCode){PathAccountSid = pathAccountSid, AreaCode = areaCode, Contains = contains, SmsEnabled = smsEnabled, MmsEnabled = mmsEnabled, VoiceEnabled = voiceEnabled, ExcludeAllAddressRequired = excludeAllAddressRequired, ExcludeLocalAddressRequired = excludeLocalAddressRequired, ExcludeForeignAddressRequired = excludeForeignAddressRequired, Beta = beta, NearNumber = nearNumber, NearLatLong = nearLatLong, Distance = distance, InPostalCode = inPostalCode, InRegion = inRegion, InRateCenter = inRateCenter, InLata = inLata, InLocality = inLocality, FaxEnabled = faxEnabled, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathCountryCode"> The ISO Country code of the country from which to read phone numbers </param>
        /// <param name="pathAccountSid"> The SID of the Account requesting the AvailablePhoneNumber resources </param>
        /// <param name="areaCode"> The area code of the phone numbers to read </param>
        /// <param name="contains"> The pattern on which to match phone numbers </param>
        /// <param name="smsEnabled"> Whether the phone numbers can receive text messages </param>
        /// <param name="mmsEnabled"> Whether the phone numbers can receive MMS messages </param>
        /// <param name="voiceEnabled"> Whether the phone numbers can receive calls. </param>
        /// <param name="excludeAllAddressRequired"> Whether to exclude phone numbers that require an Address </param>
        /// <param name="excludeLocalAddressRequired"> Whether to exclude phone numbers that require a local address </param>
        /// <param name="excludeForeignAddressRequired"> Whether to exclude phone numbers that require a foreign address
        ///                                     </param>
        /// <param name="beta"> Whether to read phone numbers new to the Twilio platform </param>
        /// <param name="nearNumber"> Given a phone number, find a geographically close number within distance miles.
        ///                  (US/Canada only) </param>
        /// <param name="nearLatLong"> Given a latitude/longitude pair lat,long find geographically close numbers within
        ///                   distance miles. (US/Canada only) </param>
        /// <param name="distance"> The search radius, in miles, for a near_ query. (US/Canada only) </param>
        /// <param name="inPostalCode"> Limit results to a particular postal code. (US/Canada only) </param>
        /// <param name="inRegion"> Limit results to a particular region. (US/Canada only) </param>
        /// <param name="inRateCenter"> Limit results to a specific rate center, or given a phone number search within the same
        ///                    rate center as that number. (US/Canada only) </param>
        /// <param name="inLata"> Limit results to a specific local access and transport area. (US/Canada only) </param>
        /// <param name="inLocality"> Limit results to a particular locality </param>
        /// <param name="faxEnabled"> Whether the phone numbers can receive faxes </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Voip </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<VoipResource>> ReadAsync(string pathCountryCode,
                                                                                             string pathAccountSid = null,
                                                                                             int? areaCode = null,
                                                                                             string contains = null,
                                                                                             bool? smsEnabled = null,
                                                                                             bool? mmsEnabled = null,
                                                                                             bool? voiceEnabled = null,
                                                                                             bool? excludeAllAddressRequired = null,
                                                                                             bool? excludeLocalAddressRequired = null,
                                                                                             bool? excludeForeignAddressRequired = null,
                                                                                             bool? beta = null,
                                                                                             Types.PhoneNumber nearNumber = null,
                                                                                             string nearLatLong = null,
                                                                                             int? distance = null,
                                                                                             string inPostalCode = null,
                                                                                             string inRegion = null,
                                                                                             string inRateCenter = null,
                                                                                             string inLata = null,
                                                                                             string inLocality = null,
                                                                                             bool? faxEnabled = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadVoipOptions(pathCountryCode){PathAccountSid = pathAccountSid, AreaCode = areaCode, Contains = contains, SmsEnabled = smsEnabled, MmsEnabled = mmsEnabled, VoiceEnabled = voiceEnabled, ExcludeAllAddressRequired = excludeAllAddressRequired, ExcludeLocalAddressRequired = excludeLocalAddressRequired, ExcludeForeignAddressRequired = excludeForeignAddressRequired, Beta = beta, NearNumber = nearNumber, NearLatLong = nearLatLong, Distance = distance, InPostalCode = inPostalCode, InRegion = inRegion, InRateCenter = inRateCenter, InLata = inLata, InLocality = inLocality, FaxEnabled = faxEnabled, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<VoipResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<VoipResource>.FromJson("available_phone_numbers", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<VoipResource> NextPage(Page<VoipResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<VoipResource>.FromJson("available_phone_numbers", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<VoipResource> PreviousPage(Page<VoipResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<VoipResource>.FromJson("available_phone_numbers", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a VoipResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> VoipResource object represented by the provided JSON </returns>
        public static VoipResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<VoipResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A formatted version of the phone number
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
        /// The LATA of this phone number
        /// </summary>
        [JsonProperty("lata")]
        public string Lata { get; private set; }
        /// <summary>
        /// The locality or city of this phone number's location
        /// </summary>
        [JsonProperty("locality")]
        public string Locality { get; private set; }
        /// <summary>
        /// The rate center of this phone number
        /// </summary>
        [JsonProperty("rate_center")]
        public string RateCenter { get; private set; }
        /// <summary>
        /// The latitude of this phone number's location
        /// </summary>
        [JsonProperty("latitude")]
        public decimal? Latitude { get; private set; }
        /// <summary>
        /// The longitude of this phone number's location
        /// </summary>
        [JsonProperty("longitude")]
        public decimal? Longitude { get; private set; }
        /// <summary>
        /// The two-letter state or province abbreviation of this phone number's location
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; private set; }
        /// <summary>
        /// The postal or ZIP code of this phone number's location
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode { get; private set; }
        /// <summary>
        /// The ISO country code of this phone number
        /// </summary>
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }
        /// <summary>
        /// The type of Address resource the phone number requires
        /// </summary>
        [JsonProperty("address_requirements")]
        public string AddressRequirements { get; private set; }
        /// <summary>
        /// Whether the phone number is new to the Twilio platform
        /// </summary>
        [JsonProperty("beta")]
        public bool? Beta { get; private set; }
        /// <summary>
        /// Whether a phone number can receive calls or messages
        /// </summary>
        [JsonProperty("capabilities")]
        public PhoneNumberCapabilities Capabilities { get; private set; }

        private VoipResource()
        {

        }
    }

}