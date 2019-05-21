/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// EntityResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Authy.V1.Service
{

    public class EntityResource : Resource
    {
        private static Request BuildCreateRequest(CreateEntityOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Authy,
                "/v1/Services/" + options.PathServiceSid + "/Entities",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new Entity for the Service
        /// </summary>
        /// <param name="options"> Create Entity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Entity </returns>
        public static EntityResource Create(CreateEntityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Entity for the Service
        /// </summary>
        /// <param name="options"> Create Entity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Entity </returns>
        public static async System.Threading.Tasks.Task<EntityResource> CreateAsync(CreateEntityOptions options,
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Entity for the Service
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="identity"> Unique identity of the Entity </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Entity </returns>
        public static EntityResource Create(string pathServiceSid, string identity, ITwilioRestClient client = null)
        {
            var options = new CreateEntityOptions(pathServiceSid, identity);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Entity for the Service
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="identity"> Unique identity of the Entity </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Entity </returns>
        public static async System.Threading.Tasks.Task<EntityResource> CreateAsync(string pathServiceSid,
                                                                                    string identity,
                                                                                    ITwilioRestClient client = null)
        {
            var options = new CreateEntityOptions(pathServiceSid, identity);
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteEntityOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Authy,
                "/v1/Services/" + options.PathServiceSid + "/Entities/" + options.PathIdentity + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete a specific Entity.
        /// </summary>
        /// <param name="options"> Delete Entity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Entity </returns>
        public static bool Delete(DeleteEntityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Entity.
        /// </summary>
        /// <param name="options"> Delete Entity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Entity </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteEntityOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a specific Entity.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Entity </returns>
        public static bool Delete(string pathServiceSid, string pathIdentity, ITwilioRestClient client = null)
        {
            var options = new DeleteEntityOptions(pathServiceSid, pathIdentity);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Entity.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Entity </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid,
                                                                          string pathIdentity,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteEntityOptions(pathServiceSid, pathIdentity);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchEntityOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Authy,
                "/v1/Services/" + options.PathServiceSid + "/Entities/" + options.PathIdentity + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch a specific Entity.
        /// </summary>
        /// <param name="options"> Fetch Entity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Entity </returns>
        public static EntityResource Fetch(FetchEntityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Entity.
        /// </summary>
        /// <param name="options"> Fetch Entity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Entity </returns>
        public static async System.Threading.Tasks.Task<EntityResource> FetchAsync(FetchEntityOptions options,
                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific Entity.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Entity </returns>
        public static EntityResource Fetch(string pathServiceSid, string pathIdentity, ITwilioRestClient client = null)
        {
            var options = new FetchEntityOptions(pathServiceSid, pathIdentity);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Entity.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Entity </returns>
        public static async System.Threading.Tasks.Task<EntityResource> FetchAsync(string pathServiceSid,
                                                                                   string pathIdentity,
                                                                                   ITwilioRestClient client = null)
        {
            var options = new FetchEntityOptions(pathServiceSid, pathIdentity);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadEntityOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Authy,
                "/v1/Services/" + options.PathServiceSid + "/Entities",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Entities for a Service.
        /// </summary>
        /// <param name="options"> Read Entity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Entity </returns>
        public static ResourceSet<EntityResource> Read(ReadEntityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<EntityResource>.FromJson("entities", response.Content);
            return new ResourceSet<EntityResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Entities for a Service.
        /// </summary>
        /// <param name="options"> Read Entity parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Entity </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EntityResource>> ReadAsync(ReadEntityOptions options,
                                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<EntityResource>.FromJson("entities", response.Content);
            return new ResourceSet<EntityResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Entities for a Service.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Entity </returns>
        public static ResourceSet<EntityResource> Read(string pathServiceSid,
                                                       int? pageSize = null,
                                                       long? limit = null,
                                                       ITwilioRestClient client = null)
        {
            var options = new ReadEntityOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Entities for a Service.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Entity </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EntityResource>> ReadAsync(string pathServiceSid,
                                                                                               int? pageSize = null,
                                                                                               long? limit = null,
                                                                                               ITwilioRestClient client = null)
        {
            var options = new ReadEntityOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<EntityResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<EntityResource>.FromJson("entities", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<EntityResource> NextPage(Page<EntityResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Authy,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<EntityResource>.FromJson("entities", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<EntityResource> PreviousPage(Page<EntityResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Authy,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<EntityResource>.FromJson("entities", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a EntityResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EntityResource object represented by the provided JSON </returns>
        public static EntityResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<EntityResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Entity.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Unique identity of the Entity
        /// </summary>
        [JsonProperty("identity")]
        public string Identity { get; private set; }
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
        /// The date this Entity was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Entity was updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Nested resource URLs.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private EntityResource()
        {

        }
    }

}