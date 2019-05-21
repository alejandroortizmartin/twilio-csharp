/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// CredentialListResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Sip
{

    public class CredentialListResource : Resource
    {
        private static Request BuildReadRequest(ReadCredentialListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/CredentialLists.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Get All Credential Lists
        /// </summary>
        /// <param name="options"> Read CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static ResourceSet<CredentialListResource> Read(ReadCredentialListOptions options,
                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<CredentialListResource>.FromJson("credential_lists", response.Content);
            return new ResourceSet<CredentialListResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Get All Credential Lists
        /// </summary>
        /// <param name="options"> Read CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialListResource>> ReadAsync(ReadCredentialListOptions options,
                                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CredentialListResource>.FromJson("credential_lists", response.Content);
            return new ResourceSet<CredentialListResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Get All Credential Lists
        /// </summary>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static ResourceSet<CredentialListResource> Read(string pathAccountSid = null,
                                                               int? pageSize = null,
                                                               long? limit = null,
                                                               ITwilioRestClient client = null)
        {
            var options = new ReadCredentialListOptions(){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Get All Credential Lists
        /// </summary>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialListResource>> ReadAsync(string pathAccountSid = null,
                                                                                                       int? pageSize = null,
                                                                                                       long? limit = null,
                                                                                                       ITwilioRestClient client = null)
        {
            var options = new ReadCredentialListOptions(){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<CredentialListResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CredentialListResource>.FromJson("credential_lists", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<CredentialListResource> NextPage(Page<CredentialListResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<CredentialListResource>.FromJson("credential_lists", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<CredentialListResource> PreviousPage(Page<CredentialListResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<CredentialListResource>.FromJson("credential_lists", response.Content);
        }

        private static Request BuildCreateRequest(CreateCredentialListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/CredentialLists.json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a Credential List
        /// </summary>
        /// <param name="options"> Create CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static CredentialListResource Create(CreateCredentialListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a Credential List
        /// </summary>
        /// <param name="options"> Create CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<CredentialListResource> CreateAsync(CreateCredentialListOptions options,
                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a Credential List
        /// </summary>
        /// <param name="friendlyName"> Human readable descriptive text </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static CredentialListResource Create(string friendlyName,
                                                    string pathAccountSid = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new CreateCredentialListOptions(friendlyName){PathAccountSid = pathAccountSid};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a Credential List
        /// </summary>
        /// <param name="friendlyName"> Human readable descriptive text </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<CredentialListResource> CreateAsync(string friendlyName,
                                                                                            string pathAccountSid = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new CreateCredentialListOptions(friendlyName){PathAccountSid = pathAccountSid};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchCredentialListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/CredentialLists/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Get a Credential List
        /// </summary>
        /// <param name="options"> Fetch CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static CredentialListResource Fetch(FetchCredentialListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Get a Credential List
        /// </summary>
        /// <param name="options"> Fetch CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<CredentialListResource> FetchAsync(FetchCredentialListOptions options,
                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Get a Credential List
        /// </summary>
        /// <param name="pathSid"> Fetch by unique credential list Sid </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static CredentialListResource Fetch(string pathSid,
                                                   string pathAccountSid = null,
                                                   ITwilioRestClient client = null)
        {
            var options = new FetchCredentialListOptions(pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Get a Credential List
        /// </summary>
        /// <param name="pathSid"> Fetch by unique credential list Sid </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<CredentialListResource> FetchAsync(string pathSid,
                                                                                           string pathAccountSid = null,
                                                                                           ITwilioRestClient client = null)
        {
            var options = new FetchCredentialListOptions(pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateCredentialListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/CredentialLists/" + options.PathSid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update a Credential List
        /// </summary>
        /// <param name="options"> Update CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static CredentialListResource Update(UpdateCredentialListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update a Credential List
        /// </summary>
        /// <param name="options"> Update CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<CredentialListResource> UpdateAsync(UpdateCredentialListOptions options,
                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update a Credential List
        /// </summary>
        /// <param name="pathSid"> Update by unique credential list Sid </param>
        /// <param name="friendlyName"> Human readable descriptive text </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static CredentialListResource Update(string pathSid,
                                                    string friendlyName,
                                                    string pathAccountSid = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new UpdateCredentialListOptions(pathSid, friendlyName){PathAccountSid = pathAccountSid};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update a Credential List
        /// </summary>
        /// <param name="pathSid"> Update by unique credential list Sid </param>
        /// <param name="friendlyName"> Human readable descriptive text </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<CredentialListResource> UpdateAsync(string pathSid,
                                                                                            string friendlyName,
                                                                                            string pathAccountSid = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new UpdateCredentialListOptions(pathSid, friendlyName){PathAccountSid = pathAccountSid};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteCredentialListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/CredentialLists/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete a Credential List
        /// </summary>
        /// <param name="options"> Delete CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static bool Delete(DeleteCredentialListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a Credential List
        /// </summary>
        /// <param name="options"> Delete CredentialList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteCredentialListOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a Credential List
        /// </summary>
        /// <param name="pathSid"> Delete by unique credential list Sid </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialList </returns>
        public static bool Delete(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteCredentialListOptions(pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a Credential List
        /// </summary>
        /// <param name="pathSid"> Delete by unique credential list Sid </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialList </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid,
                                                                          string pathAccountSid = null,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteCredentialListOptions(pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a CredentialListResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CredentialListResource object represented by the provided JSON </returns>
        public static CredentialListResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<CredentialListResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The date this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// Human readable descriptive text
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this credential
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The list of credentials associated with this credential list.
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }
        /// <summary>
        /// The URI for this resource
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }

        private CredentialListResource()
        {

        }
    }

}