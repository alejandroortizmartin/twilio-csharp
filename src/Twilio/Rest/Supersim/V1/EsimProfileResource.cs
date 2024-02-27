/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Supersim
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Constant;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;


namespace Twilio.Rest.Supersim.V1
{
    public class EsimProfileResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum New = new StatusEnum("new");
            public static readonly StatusEnum Reserving = new StatusEnum("reserving");
            public static readonly StatusEnum Available = new StatusEnum("available");
            public static readonly StatusEnum Downloaded = new StatusEnum("downloaded");
            public static readonly StatusEnum Installed = new StatusEnum("installed");
            public static readonly StatusEnum Failed = new StatusEnum("failed");

        }

        
        private static Request BuildCreateRequest(CreateEsimProfileOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/ESimProfiles";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Supersim,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Order an eSIM Profile. </summary>
        /// <param name="options"> Create EsimProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of EsimProfile </returns>
        public static EsimProfileResource Create(CreateEsimProfileOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Order an eSIM Profile. </summary>
        /// <param name="options"> Create EsimProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of EsimProfile </returns>
        public static async System.Threading.Tasks.Task<EsimProfileResource> CreateAsync(CreateEsimProfileOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Order an eSIM Profile. </summary>
        /// <param name="callbackUrl"> The URL we should call using the `callback_method` when the status of the eSIM Profile changes. At this stage of the eSIM Profile pilot, the a request to the URL will only be called when the ESimProfile resource changes from `reserving` to `available`. </param>
        /// <param name="callbackMethod"> The HTTP method we should use to call `callback_url`. Can be: `GET` or `POST` and the default is POST. </param>
        /// <param name="generateMatchingId"> When set to `true`, a value for `Eid` does not need to be provided. Instead, when the eSIM profile is reserved, a matching ID will be generated and returned via the `matching_id` property. This identifies the specific eSIM profile that can be used by any capable device to claim and download the profile. </param>
        /// <param name="eid"> Identifier of the eUICC that will claim the eSIM Profile. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of EsimProfile </returns>
        public static EsimProfileResource Create(
                                          string callbackUrl = null,
                                          Twilio.Http.HttpMethod callbackMethod = null,
                                          bool? generateMatchingId = null,
                                          string eid = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateEsimProfileOptions(){  CallbackUrl = callbackUrl, CallbackMethod = callbackMethod, GenerateMatchingId = generateMatchingId, Eid = eid };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Order an eSIM Profile. </summary>
        /// <param name="callbackUrl"> The URL we should call using the `callback_method` when the status of the eSIM Profile changes. At this stage of the eSIM Profile pilot, the a request to the URL will only be called when the ESimProfile resource changes from `reserving` to `available`. </param>
        /// <param name="callbackMethod"> The HTTP method we should use to call `callback_url`. Can be: `GET` or `POST` and the default is POST. </param>
        /// <param name="generateMatchingId"> When set to `true`, a value for `Eid` does not need to be provided. Instead, when the eSIM profile is reserved, a matching ID will be generated and returned via the `matching_id` property. This identifies the specific eSIM profile that can be used by any capable device to claim and download the profile. </param>
        /// <param name="eid"> Identifier of the eUICC that will claim the eSIM Profile. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of EsimProfile </returns>
        public static async System.Threading.Tasks.Task<EsimProfileResource> CreateAsync(
                                                                                  string callbackUrl = null,
                                                                                  Twilio.Http.HttpMethod callbackMethod = null,
                                                                                  bool? generateMatchingId = null,
                                                                                  string eid = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateEsimProfileOptions(){  CallbackUrl = callbackUrl, CallbackMethod = callbackMethod, GenerateMatchingId = generateMatchingId, Eid = eid };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchEsimProfileOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/ESimProfiles/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch an eSIM Profile. </summary>
        /// <param name="options"> Fetch EsimProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of EsimProfile </returns>
        public static EsimProfileResource Fetch(FetchEsimProfileOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch an eSIM Profile. </summary>
        /// <param name="options"> Fetch EsimProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of EsimProfile </returns>
        public static async System.Threading.Tasks.Task<EsimProfileResource> FetchAsync(FetchEsimProfileOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch an eSIM Profile. </summary>
        /// <param name="pathSid"> The SID of the eSIM Profile resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of EsimProfile </returns>
        public static EsimProfileResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchEsimProfileOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch an eSIM Profile. </summary>
        /// <param name="pathSid"> The SID of the eSIM Profile resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of EsimProfile </returns>
        public static async System.Threading.Tasks.Task<EsimProfileResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchEsimProfileOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadEsimProfileOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/ESimProfiles";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of eSIM Profiles. </summary>
        /// <param name="options"> Read EsimProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of EsimProfile </returns>
        public static ResourceSet<EsimProfileResource> Read(ReadEsimProfileOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<EsimProfileResource>.FromJson("esim_profiles", response.Content);
            return new ResourceSet<EsimProfileResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of eSIM Profiles. </summary>
        /// <param name="options"> Read EsimProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of EsimProfile </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EsimProfileResource>> ReadAsync(ReadEsimProfileOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<EsimProfileResource>.FromJson("esim_profiles", response.Content);
            return new ResourceSet<EsimProfileResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of eSIM Profiles. </summary>
        /// <param name="eid"> List the eSIM Profiles that have been associated with an EId. </param>
        /// <param name="simSid"> Find the eSIM Profile resource related to a [Sim](https://www.twilio.com/docs/iot/supersim/api/sim-resource) resource by providing the SIM SID. Will always return an array with either 1 or 0 records. </param>
        /// <param name="status"> List the eSIM Profiles that are in a given status. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of EsimProfile </returns>
        public static ResourceSet<EsimProfileResource> Read(
                                                     string eid = null,
                                                     string simSid = null,
                                                     EsimProfileResource.StatusEnum status = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadEsimProfileOptions(){ Eid = eid, SimSid = simSid, Status = status, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of eSIM Profiles. </summary>
        /// <param name="eid"> List the eSIM Profiles that have been associated with an EId. </param>
        /// <param name="simSid"> Find the eSIM Profile resource related to a [Sim](https://www.twilio.com/docs/iot/supersim/api/sim-resource) resource by providing the SIM SID. Will always return an array with either 1 or 0 records. </param>
        /// <param name="status"> List the eSIM Profiles that are in a given status. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of EsimProfile </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EsimProfileResource>> ReadAsync(
                                                                                             string eid = null,
                                                                                             string simSid = null,
                                                                                             EsimProfileResource.StatusEnum status = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadEsimProfileOptions(){ Eid = eid, SimSid = simSid, Status = status, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<EsimProfileResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<EsimProfileResource>.FromJson("esim_profiles", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<EsimProfileResource> NextPage(Page<EsimProfileResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<EsimProfileResource>.FromJson("esim_profiles", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<EsimProfileResource> PreviousPage(Page<EsimProfileResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<EsimProfileResource>.FromJson("esim_profiles", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a EsimProfileResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EsimProfileResource object represented by the provided JSON </returns>
        public static EsimProfileResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<EsimProfileResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
        /// <summary>
    /// Converts an object into a json string
    /// </summary>
    /// <param name="model"> C# model </param>
    /// <returns> JSON string </returns>
    public static string ToJson(object model)
    {
        try
        {
            return JsonConvert.SerializeObject(model);
        }
        catch (JsonException e)
        {
            throw new ApiException(e.Message, e);
        }
    }

    
        ///<summary> The unique string that we created to identify the eSIM Profile resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) to which the eSIM Profile resource belongs. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The [ICCID](https://en.wikipedia.org/wiki/Subscriber_identity_module#ICCID) associated with the Sim resource. </summary> 
        [JsonProperty("iccid")]
        public string Iccid { get; private set; }

        ///<summary> The SID of the [Sim](https://www.twilio.com/docs/iot/supersim/api/sim-resource) resource that this eSIM Profile controls. </summary> 
        [JsonProperty("sim_sid")]
        public string SimSid { get; private set; }

        
        [JsonProperty("status")]
        public EsimProfileResource.StatusEnum Status { get; private set; }

        ///<summary> Identifier of the eUICC that can claim the eSIM Profile. </summary> 
        [JsonProperty("eid")]
        public string Eid { get; private set; }

        ///<summary> Address of the SM-DP+ server from which the Profile will be downloaded. The URL will appear once the eSIM Profile reaches the status `available`. </summary> 
        [JsonProperty("smdp_plus_address")]
        public Uri SmdpPlusAddress { get; private set; }

        ///<summary> Unique identifier of the eSIM profile that can be used to identify and download the eSIM profile from the SM-DP+ server. Populated if `generate_matching_id` is set to `true` when creating the eSIM profile reservation. </summary> 
        [JsonProperty("matching_id")]
        public string MatchingId { get; private set; }

        ///<summary> Combined machine-readable activation code for acquiring an eSIM Profile with the Activation Code download method. Can be used in a QR code to download an eSIM profile. </summary> 
        [JsonProperty("activation_code")]
        public string ActivationCode { get; private set; }

        ///<summary> Code indicating the failure if the download of the SIM Profile failed and the eSIM Profile is in `failed` state. </summary> 
        [JsonProperty("error_code")]
        public string ErrorCode { get; private set; }

        ///<summary> Error message describing the failure if the download of the SIM Profile failed and the eSIM Profile is in `failed` state. </summary> 
        [JsonProperty("error_message")]
        public string ErrorMessage { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the eSIM Profile resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private EsimProfileResource() {

        }
    }
}

