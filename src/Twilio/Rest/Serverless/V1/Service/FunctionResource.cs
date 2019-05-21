/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// FunctionResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Serverless.V1.Service
{

    public class FunctionResource : Resource
    {
        private static Request BuildReadRequest(ReadFunctionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Functions",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Functions.
        /// </summary>
        /// <param name="options"> Read Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static ResourceSet<FunctionResource> Read(ReadFunctionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<FunctionResource>.FromJson("functions", response.Content);
            return new ResourceSet<FunctionResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Functions.
        /// </summary>
        /// <param name="options"> Read Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FunctionResource>> ReadAsync(ReadFunctionOptions options,
                                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FunctionResource>.FromJson("functions", response.Content);
            return new ResourceSet<FunctionResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Functions.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static ResourceSet<FunctionResource> Read(string pathServiceSid,
                                                         int? pageSize = null,
                                                         long? limit = null,
                                                         ITwilioRestClient client = null)
        {
            var options = new ReadFunctionOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Functions.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FunctionResource>> ReadAsync(string pathServiceSid,
                                                                                                 int? pageSize = null,
                                                                                                 long? limit = null,
                                                                                                 ITwilioRestClient client = null)
        {
            var options = new ReadFunctionOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<FunctionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FunctionResource>.FromJson("functions", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<FunctionResource> NextPage(Page<FunctionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FunctionResource>.FromJson("functions", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<FunctionResource> PreviousPage(Page<FunctionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FunctionResource>.FromJson("functions", response.Content);
        }

        private static Request BuildFetchRequest(FetchFunctionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Functions/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a specific Function.
        /// </summary>
        /// <param name="options"> Fetch Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static FunctionResource Fetch(FetchFunctionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a specific Function.
        /// </summary>
        /// <param name="options"> Fetch Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<FunctionResource> FetchAsync(FetchFunctionOptions options,
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieve a specific Function.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSid"> Function Sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static FunctionResource Fetch(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchFunctionOptions(pathServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a specific Function.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSid"> Function Sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<FunctionResource> FetchAsync(string pathServiceSid,
                                                                                     string pathSid,
                                                                                     ITwilioRestClient client = null)
        {
            var options = new FetchFunctionOptions(pathServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateFunctionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Functions",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new Function.
        /// </summary>
        /// <param name="options"> Create Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static FunctionResource Create(CreateFunctionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Function.
        /// </summary>
        /// <param name="options"> Create Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<FunctionResource> CreateAsync(CreateFunctionOptions options,
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Function.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="friendlyName"> A human-readable description of this Function. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static FunctionResource Create(string pathServiceSid, string friendlyName, ITwilioRestClient client = null)
        {
            var options = new CreateFunctionOptions(pathServiceSid, friendlyName);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Function.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="friendlyName"> A human-readable description of this Function. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<FunctionResource> CreateAsync(string pathServiceSid,
                                                                                      string friendlyName,
                                                                                      ITwilioRestClient client = null)
        {
            var options = new CreateFunctionOptions(pathServiceSid, friendlyName);
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateFunctionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Functions/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update a specific Function.
        /// </summary>
        /// <param name="options"> Update Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static FunctionResource Update(UpdateFunctionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update a specific Function.
        /// </summary>
        /// <param name="options"> Update Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<FunctionResource> UpdateAsync(UpdateFunctionOptions options,
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update a specific Function.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSid"> Function Sid. </param>
        /// <param name="friendlyName"> A human-readable description of this Function. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static FunctionResource Update(string pathServiceSid,
                                              string pathSid,
                                              string friendlyName,
                                              ITwilioRestClient client = null)
        {
            var options = new UpdateFunctionOptions(pathServiceSid, pathSid, friendlyName);
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update a specific Function.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSid"> Function Sid. </param>
        /// <param name="friendlyName"> A human-readable description of this Function. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<FunctionResource> UpdateAsync(string pathServiceSid,
                                                                                      string pathSid,
                                                                                      string friendlyName,
                                                                                      ITwilioRestClient client = null)
        {
            var options = new UpdateFunctionOptions(pathServiceSid, pathSid, friendlyName);
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a FunctionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FunctionResource object represented by the provided JSON </returns>
        public static FunctionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FunctionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Function Sid.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Service Sid.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// A human-readable description of this Function.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The date that this Function was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this Function was updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URL of this Function.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Nested resource URLs.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private FunctionResource()
        {

        }
    }

}