/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Intelligence
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


namespace Twilio.Rest.Intelligence.V2
{
    public class TranscriptResource : Resource
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
            public static readonly StatusEnum Queued = new StatusEnum("queued");
            public static readonly StatusEnum InProgress = new StatusEnum("in-progress");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
            public static readonly StatusEnum Canceled = new StatusEnum("canceled");

        }

        
        private static Request BuildCreateRequest(CreateTranscriptOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Transcripts";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Intelligence,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Transcript for the service </summary>
        /// <param name="options"> Create Transcript parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcript </returns>
        public static TranscriptResource Create(CreateTranscriptOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Transcript for the service </summary>
        /// <param name="options"> Create Transcript parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcript </returns>
        public static async System.Threading.Tasks.Task<TranscriptResource> CreateAsync(CreateTranscriptOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Transcript for the service </summary>
        /// <param name="serviceSid"> The unique SID identifier of the Service. </param>
        /// <param name="channel"> JSON object describing Media Channel including Source and Participants </param>
        /// <param name="customerKey"> Used to store client provided metadata. Maximum of 64 double-byte UTF8 characters. </param>
        /// <param name="mediaStartTime"> The date that this Transcript's media was started, given in ISO 8601 format. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcript </returns>
        public static TranscriptResource Create(
                                          string serviceSid,
                                          object channel,
                                          string customerKey = null,
                                          DateTime? mediaStartTime = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateTranscriptOptions(serviceSid, channel){  CustomerKey = customerKey, MediaStartTime = mediaStartTime };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Transcript for the service </summary>
        /// <param name="serviceSid"> The unique SID identifier of the Service. </param>
        /// <param name="channel"> JSON object describing Media Channel including Source and Participants </param>
        /// <param name="customerKey"> Used to store client provided metadata. Maximum of 64 double-byte UTF8 characters. </param>
        /// <param name="mediaStartTime"> The date that this Transcript's media was started, given in ISO 8601 format. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcript </returns>
        public static async System.Threading.Tasks.Task<TranscriptResource> CreateAsync(
                                                                                  string serviceSid,
                                                                                  object channel,
                                                                                  string customerKey = null,
                                                                                  DateTime? mediaStartTime = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateTranscriptOptions(serviceSid, channel){  CustomerKey = customerKey, MediaStartTime = mediaStartTime };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a specific Transcript. </summary>
        /// <param name="options"> Delete Transcript parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcript </returns>
        private static Request BuildDeleteRequest(DeleteTranscriptOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Transcripts/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Intelligence,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Transcript. </summary>
        /// <param name="options"> Delete Transcript parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcript </returns>
        public static bool Delete(DeleteTranscriptOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific Transcript. </summary>
        /// <param name="options"> Delete Transcript parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcript </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteTranscriptOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific Transcript. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Transcript. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcript </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteTranscriptOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific Transcript. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Transcript. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcript </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteTranscriptOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchTranscriptOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Transcripts/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Intelligence,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific Transcript. </summary>
        /// <param name="options"> Fetch Transcript parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcript </returns>
        public static TranscriptResource Fetch(FetchTranscriptOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Transcript. </summary>
        /// <param name="options"> Fetch Transcript parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcript </returns>
        public static async System.Threading.Tasks.Task<TranscriptResource> FetchAsync(FetchTranscriptOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Transcript. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Transcript. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcript </returns>
        public static TranscriptResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchTranscriptOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Transcript. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Transcript. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcript </returns>
        public static async System.Threading.Tasks.Task<TranscriptResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchTranscriptOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadTranscriptOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Transcripts";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Intelligence,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Transcripts for a given service. </summary>
        /// <param name="options"> Read Transcript parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcript </returns>
        public static ResourceSet<TranscriptResource> Read(ReadTranscriptOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<TranscriptResource>.FromJson("transcripts", response.Content);
            return new ResourceSet<TranscriptResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Transcripts for a given service. </summary>
        /// <param name="options"> Read Transcript parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcript </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TranscriptResource>> ReadAsync(ReadTranscriptOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<TranscriptResource>.FromJson("transcripts", response.Content);
            return new ResourceSet<TranscriptResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of Transcripts for a given service. </summary>
        /// <param name="serviceSid"> The unique SID identifier of the Service. </param>
        /// <param name="beforeStartTime"> Filter by before StartTime. </param>
        /// <param name="afterStartTime"> Filter by after StartTime. </param>
        /// <param name="beforeDateCreated"> Filter by before DateCreated. </param>
        /// <param name="afterDateCreated"> Filter by after DateCreated. </param>
        /// <param name="status"> Filter by status. </param>
        /// <param name="languageCode"> Filter by Language Code. </param>
        /// <param name="sourceSid"> Filter by SourceSid. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Transcript </returns>
        public static ResourceSet<TranscriptResource> Read(
                                                     string serviceSid = null,
                                                     string beforeStartTime = null,
                                                     string afterStartTime = null,
                                                     string beforeDateCreated = null,
                                                     string afterDateCreated = null,
                                                     string status = null,
                                                     string languageCode = null,
                                                     string sourceSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadTranscriptOptions(){ ServiceSid = serviceSid, BeforeStartTime = beforeStartTime, AfterStartTime = afterStartTime, BeforeDateCreated = beforeDateCreated, AfterDateCreated = afterDateCreated, Status = status, LanguageCode = languageCode, SourceSid = sourceSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Transcripts for a given service. </summary>
        /// <param name="serviceSid"> The unique SID identifier of the Service. </param>
        /// <param name="beforeStartTime"> Filter by before StartTime. </param>
        /// <param name="afterStartTime"> Filter by after StartTime. </param>
        /// <param name="beforeDateCreated"> Filter by before DateCreated. </param>
        /// <param name="afterDateCreated"> Filter by after DateCreated. </param>
        /// <param name="status"> Filter by status. </param>
        /// <param name="languageCode"> Filter by Language Code. </param>
        /// <param name="sourceSid"> Filter by SourceSid. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Transcript </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TranscriptResource>> ReadAsync(
                                                                                             string serviceSid = null,
                                                                                             string beforeStartTime = null,
                                                                                             string afterStartTime = null,
                                                                                             string beforeDateCreated = null,
                                                                                             string afterDateCreated = null,
                                                                                             string status = null,
                                                                                             string languageCode = null,
                                                                                             string sourceSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadTranscriptOptions(){ ServiceSid = serviceSid, BeforeStartTime = beforeStartTime, AfterStartTime = afterStartTime, BeforeDateCreated = beforeDateCreated, AfterDateCreated = afterDateCreated, Status = status, LanguageCode = languageCode, SourceSid = sourceSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<TranscriptResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<TranscriptResource>.FromJson("transcripts", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<TranscriptResource> NextPage(Page<TranscriptResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<TranscriptResource>.FromJson("transcripts", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<TranscriptResource> PreviousPage(Page<TranscriptResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<TranscriptResource>.FromJson("transcripts", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a TranscriptResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TranscriptResource object represented by the provided JSON </returns>
        public static TranscriptResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<TranscriptResource>(json);
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

    
        ///<summary> The unique SID identifier of the Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique SID identifier of the Service. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies this Transcript. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The date that this Transcript was created, given in ISO 8601 format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this Transcript was updated, given in ISO 8601 format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        
        [JsonProperty("status")]
        public TranscriptResource.StatusEnum Status { get; private set; }

        ///<summary> Media Channel describing Transcript Source and Participant Mapping </summary> 
        [JsonProperty("channel")]
        public object Channel { get; private set; }

        ///<summary> Data logging allows Twilio to improve the quality of the speech recognition through using customer data to refine its speech recognition models. </summary> 
        [JsonProperty("data_logging")]
        public bool? DataLogging { get; private set; }

        ///<summary> The default language code of the audio. </summary> 
        [JsonProperty("language_code")]
        public string LanguageCode { get; private set; }

        ///<summary> The customer_key </summary> 
        [JsonProperty("customer_key")]
        public string CustomerKey { get; private set; }

        ///<summary> The date that this Transcript's media was started, given in ISO 8601 format. </summary> 
        [JsonProperty("media_start_time")]
        public DateTime? MediaStartTime { get; private set; }

        ///<summary> The duration of this Transcript's source </summary> 
        [JsonProperty("duration")]
        public int? Duration { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> If the transcript has been redacted, a redacted alternative of the transcript will be available. </summary> 
        [JsonProperty("redaction")]
        public bool? Redaction { get; private set; }

        ///<summary> The links </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private TranscriptResource() {

        }
    }
}

