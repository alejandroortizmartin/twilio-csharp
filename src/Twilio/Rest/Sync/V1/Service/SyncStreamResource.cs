/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// SyncStreamResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Sync.V1.Service
{

    public class SyncStreamResource : Resource
    {
        private static Request BuildFetchRequest(FetchSyncStreamOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Streams/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch a specific Stream.
        /// </summary>
        /// <param name="options"> Fetch SyncStream parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncStream </returns>
        public static SyncStreamResource Fetch(FetchSyncStreamOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Stream.
        /// </summary>
        /// <param name="options"> Fetch SyncStream parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncStream </returns>
        public static async System.Threading.Tasks.Task<SyncStreamResource> FetchAsync(FetchSyncStreamOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific Stream.
        /// </summary>
        /// <param name="pathServiceSid"> Service Instance SID or unique name. </param>
        /// <param name="pathSid"> Stream SID or unique name. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncStream </returns>
        public static SyncStreamResource Fetch(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchSyncStreamOptions(pathServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Stream.
        /// </summary>
        /// <param name="pathServiceSid"> Service Instance SID or unique name. </param>
        /// <param name="pathSid"> Stream SID or unique name. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncStream </returns>
        public static async System.Threading.Tasks.Task<SyncStreamResource> FetchAsync(string pathServiceSid,
                                                                                       string pathSid,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new FetchSyncStreamOptions(pathServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteSyncStreamOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Streams/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete a specific Stream.
        /// </summary>
        /// <param name="options"> Delete SyncStream parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncStream </returns>
        public static bool Delete(DeleteSyncStreamOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Stream.
        /// </summary>
        /// <param name="options"> Delete SyncStream parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncStream </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSyncStreamOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a specific Stream.
        /// </summary>
        /// <param name="pathServiceSid"> Service Instance SID or unique name. </param>
        /// <param name="pathSid"> Stream SID or unique name. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncStream </returns>
        public static bool Delete(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteSyncStreamOptions(pathServiceSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Stream.
        /// </summary>
        /// <param name="pathServiceSid"> Service Instance SID or unique name. </param>
        /// <param name="pathSid"> Stream SID or unique name. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncStream </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid,
                                                                          string pathSid,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteSyncStreamOptions(pathServiceSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateSyncStreamOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Streams",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new Stream.
        /// </summary>
        /// <param name="options"> Create SyncStream parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncStream </returns>
        public static SyncStreamResource Create(CreateSyncStreamOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Stream.
        /// </summary>
        /// <param name="options"> Create SyncStream parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncStream </returns>
        public static async System.Threading.Tasks.Task<SyncStreamResource> CreateAsync(CreateSyncStreamOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Stream.
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="uniqueName"> Stream unique name. </param>
        /// <param name="ttl"> Stream TTL. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncStream </returns>
        public static SyncStreamResource Create(string pathServiceSid,
                                                string uniqueName = null,
                                                int? ttl = null,
                                                ITwilioRestClient client = null)
        {
            var options = new CreateSyncStreamOptions(pathServiceSid){UniqueName = uniqueName, Ttl = ttl};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Stream.
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="uniqueName"> Stream unique name. </param>
        /// <param name="ttl"> Stream TTL. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncStream </returns>
        public static async System.Threading.Tasks.Task<SyncStreamResource> CreateAsync(string pathServiceSid,
                                                                                        string uniqueName = null,
                                                                                        int? ttl = null,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new CreateSyncStreamOptions(pathServiceSid){UniqueName = uniqueName, Ttl = ttl};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateSyncStreamOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Streams/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update a specific Stream.
        /// </summary>
        /// <param name="options"> Update SyncStream parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncStream </returns>
        public static SyncStreamResource Update(UpdateSyncStreamOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update a specific Stream.
        /// </summary>
        /// <param name="options"> Update SyncStream parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncStream </returns>
        public static async System.Threading.Tasks.Task<SyncStreamResource> UpdateAsync(UpdateSyncStreamOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update a specific Stream.
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="ttl"> Stream TTL. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncStream </returns>
        public static SyncStreamResource Update(string pathServiceSid,
                                                string pathSid,
                                                int? ttl = null,
                                                ITwilioRestClient client = null)
        {
            var options = new UpdateSyncStreamOptions(pathServiceSid, pathSid){Ttl = ttl};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update a specific Stream.
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="ttl"> Stream TTL. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncStream </returns>
        public static async System.Threading.Tasks.Task<SyncStreamResource> UpdateAsync(string pathServiceSid,
                                                                                        string pathSid,
                                                                                        int? ttl = null,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new UpdateSyncStreamOptions(pathServiceSid, pathSid){Ttl = ttl};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadSyncStreamOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Streams",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Streams in a Service Instance.
        /// </summary>
        /// <param name="options"> Read SyncStream parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncStream </returns>
        public static ResourceSet<SyncStreamResource> Read(ReadSyncStreamOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<SyncStreamResource>.FromJson("streams", response.Content);
            return new ResourceSet<SyncStreamResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Streams in a Service Instance.
        /// </summary>
        /// <param name="options"> Read SyncStream parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncStream </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SyncStreamResource>> ReadAsync(ReadSyncStreamOptions options,
                                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SyncStreamResource>.FromJson("streams", response.Content);
            return new ResourceSet<SyncStreamResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Streams in a Service Instance.
        /// </summary>
        /// <param name="pathServiceSid"> Service Instance SID or unique name. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncStream </returns>
        public static ResourceSet<SyncStreamResource> Read(string pathServiceSid,
                                                           int? pageSize = null,
                                                           long? limit = null,
                                                           ITwilioRestClient client = null)
        {
            var options = new ReadSyncStreamOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Streams in a Service Instance.
        /// </summary>
        /// <param name="pathServiceSid"> Service Instance SID or unique name. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncStream </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SyncStreamResource>> ReadAsync(string pathServiceSid,
                                                                                                   int? pageSize = null,
                                                                                                   long? limit = null,
                                                                                                   ITwilioRestClient client = null)
        {
            var options = new ReadSyncStreamOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SyncStreamResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SyncStreamResource>.FromJson("streams", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SyncStreamResource> NextPage(Page<SyncStreamResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Sync,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<SyncStreamResource>.FromJson("streams", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SyncStreamResource> PreviousPage(Page<SyncStreamResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Sync,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<SyncStreamResource>.FromJson("streams", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a SyncStreamResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SyncStreamResource object represented by the provided JSON </returns>
        public static SyncStreamResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SyncStreamResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Stream SID.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Stream unique name.
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// Twilio Account SID.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Service Instance SID.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// URL of this Stream.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Nested resource URLs.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
        /// <summary>
        /// The date this Stream expires.
        /// </summary>
        [JsonProperty("date_expires")]
        public DateTime? DateExpires { get; private set; }
        /// <summary>
        /// The date this Stream was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Stream was updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// Identity of the Stream creator.
        /// </summary>
        [JsonProperty("created_by")]
        public string CreatedBy { get; private set; }

        private SyncStreamResource()
        {

        }
    }

}