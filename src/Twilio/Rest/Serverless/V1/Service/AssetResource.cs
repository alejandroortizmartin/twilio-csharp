/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// AssetResource
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

    public class AssetResource : Resource
    {
        private static Request BuildReadRequest(ReadAssetOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Assets",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Assets.
        /// </summary>
        /// <param name="options"> Read Asset parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Asset </returns>
        public static ResourceSet<AssetResource> Read(ReadAssetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<AssetResource>.FromJson("assets", response.Content);
            return new ResourceSet<AssetResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Assets.
        /// </summary>
        /// <param name="options"> Read Asset parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Asset </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AssetResource>> ReadAsync(ReadAssetOptions options,
                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AssetResource>.FromJson("assets", response.Content);
            return new ResourceSet<AssetResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Assets.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Asset </returns>
        public static ResourceSet<AssetResource> Read(string pathServiceSid,
                                                      int? pageSize = null,
                                                      long? limit = null,
                                                      ITwilioRestClient client = null)
        {
            var options = new ReadAssetOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Assets.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Asset </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AssetResource>> ReadAsync(string pathServiceSid,
                                                                                              int? pageSize = null,
                                                                                              long? limit = null,
                                                                                              ITwilioRestClient client = null)
        {
            var options = new ReadAssetOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AssetResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AssetResource>.FromJson("assets", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AssetResource> NextPage(Page<AssetResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AssetResource>.FromJson("assets", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AssetResource> PreviousPage(Page<AssetResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AssetResource>.FromJson("assets", response.Content);
        }

        private static Request BuildFetchRequest(FetchAssetOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Assets/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a specific Asset.
        /// </summary>
        /// <param name="options"> Fetch Asset parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Asset </returns>
        public static AssetResource Fetch(FetchAssetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a specific Asset.
        /// </summary>
        /// <param name="options"> Fetch Asset parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Asset </returns>
        public static async System.Threading.Tasks.Task<AssetResource> FetchAsync(FetchAssetOptions options,
                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieve a specific Asset.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSid"> Asset Sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Asset </returns>
        public static AssetResource Fetch(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchAssetOptions(pathServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a specific Asset.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSid"> Asset Sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Asset </returns>
        public static async System.Threading.Tasks.Task<AssetResource> FetchAsync(string pathServiceSid,
                                                                                  string pathSid,
                                                                                  ITwilioRestClient client = null)
        {
            var options = new FetchAssetOptions(pathServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateAssetOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Assets",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new Asset.
        /// </summary>
        /// <param name="options"> Create Asset parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Asset </returns>
        public static AssetResource Create(CreateAssetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Asset.
        /// </summary>
        /// <param name="options"> Create Asset parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Asset </returns>
        public static async System.Threading.Tasks.Task<AssetResource> CreateAsync(CreateAssetOptions options,
                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Asset.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="friendlyName"> A human-readable description of this Asset. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Asset </returns>
        public static AssetResource Create(string pathServiceSid, string friendlyName, ITwilioRestClient client = null)
        {
            var options = new CreateAssetOptions(pathServiceSid, friendlyName);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Asset.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="friendlyName"> A human-readable description of this Asset. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Asset </returns>
        public static async System.Threading.Tasks.Task<AssetResource> CreateAsync(string pathServiceSid,
                                                                                   string friendlyName,
                                                                                   ITwilioRestClient client = null)
        {
            var options = new CreateAssetOptions(pathServiceSid, friendlyName);
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateAssetOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Assets/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update a specific Asset.
        /// </summary>
        /// <param name="options"> Update Asset parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Asset </returns>
        public static AssetResource Update(UpdateAssetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update a specific Asset.
        /// </summary>
        /// <param name="options"> Update Asset parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Asset </returns>
        public static async System.Threading.Tasks.Task<AssetResource> UpdateAsync(UpdateAssetOptions options,
                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update a specific Asset.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSid"> Asset Sid. </param>
        /// <param name="friendlyName"> A human-readable description of this Asset. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Asset </returns>
        public static AssetResource Update(string pathServiceSid,
                                           string pathSid,
                                           string friendlyName,
                                           ITwilioRestClient client = null)
        {
            var options = new UpdateAssetOptions(pathServiceSid, pathSid, friendlyName);
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update a specific Asset.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSid"> Asset Sid. </param>
        /// <param name="friendlyName"> A human-readable description of this Asset. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Asset </returns>
        public static async System.Threading.Tasks.Task<AssetResource> UpdateAsync(string pathServiceSid,
                                                                                   string pathSid,
                                                                                   string friendlyName,
                                                                                   ITwilioRestClient client = null)
        {
            var options = new UpdateAssetOptions(pathServiceSid, pathSid, friendlyName);
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a AssetResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AssetResource object represented by the provided JSON </returns>
        public static AssetResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AssetResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Asset Sid.
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
        /// A human-readable description of this Asset.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The date that this Asset was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this Asset was updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URL of this Asset.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Nested resource URLs.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private AssetResource()
        {

        }
    }

}