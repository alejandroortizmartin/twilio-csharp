/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// FieldValueResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.Understand.Assistant.FieldType
{

    public class FieldValueResource : Resource
    {
        private static Request BuildFetchRequest(FetchFieldValueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/understand/Assistants/" + options.PathAssistantSid + "/FieldTypes/" + options.PathFieldTypeSid + "/FieldValues/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FieldValue </returns>
        public static FieldValueResource Fetch(FetchFieldValueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<FieldValueResource> FetchAsync(FetchFieldValueOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathFieldTypeSid"> The field_type_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FieldValue </returns>
        public static FieldValueResource Fetch(string pathAssistantSid,
                                               string pathFieldTypeSid,
                                               string pathSid,
                                               ITwilioRestClient client = null)
        {
            var options = new FetchFieldValueOptions(pathAssistantSid, pathFieldTypeSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathFieldTypeSid"> The field_type_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<FieldValueResource> FetchAsync(string pathAssistantSid,
                                                                                       string pathFieldTypeSid,
                                                                                       string pathSid,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new FetchFieldValueOptions(pathAssistantSid, pathFieldTypeSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadFieldValueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/understand/Assistants/" + options.PathAssistantSid + "/FieldTypes/" + options.PathFieldTypeSid + "/FieldValues",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FieldValue </returns>
        public static ResourceSet<FieldValueResource> Read(ReadFieldValueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<FieldValueResource>.FromJson("field_values", response.Content);
            return new ResourceSet<FieldValueResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FieldValueResource>> ReadAsync(ReadFieldValueOptions options,
                                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FieldValueResource>.FromJson("field_values", response.Content);
            return new ResourceSet<FieldValueResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathFieldTypeSid"> The field_type_sid </param>
        /// <param name="language"> An ISO language-country string of the value. For example: en-US </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FieldValue </returns>
        public static ResourceSet<FieldValueResource> Read(string pathAssistantSid,
                                                           string pathFieldTypeSid,
                                                           string language = null,
                                                           int? pageSize = null,
                                                           long? limit = null,
                                                           ITwilioRestClient client = null)
        {
            var options = new ReadFieldValueOptions(pathAssistantSid, pathFieldTypeSid){Language = language, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathFieldTypeSid"> The field_type_sid </param>
        /// <param name="language"> An ISO language-country string of the value. For example: en-US </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FieldValueResource>> ReadAsync(string pathAssistantSid,
                                                                                                   string pathFieldTypeSid,
                                                                                                   string language = null,
                                                                                                   int? pageSize = null,
                                                                                                   long? limit = null,
                                                                                                   ITwilioRestClient client = null)
        {
            var options = new ReadFieldValueOptions(pathAssistantSid, pathFieldTypeSid){Language = language, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<FieldValueResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FieldValueResource>.FromJson("field_values", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<FieldValueResource> NextPage(Page<FieldValueResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FieldValueResource>.FromJson("field_values", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<FieldValueResource> PreviousPage(Page<FieldValueResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FieldValueResource>.FromJson("field_values", response.Content);
        }

        private static Request BuildCreateRequest(CreateFieldValueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/understand/Assistants/" + options.PathAssistantSid + "/FieldTypes/" + options.PathFieldTypeSid + "/FieldValues",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FieldValue </returns>
        public static FieldValueResource Create(CreateFieldValueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<FieldValueResource> CreateAsync(CreateFieldValueOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathFieldTypeSid"> The field_type_sid </param>
        /// <param name="language"> An ISO language-country string of the value. </param>
        /// <param name="value"> A user-provided string that uniquely identifies this resource as an alternative to the sid.
        ///             Unique up to 64 characters long. </param>
        /// <param name="synonymOf"> A value that indicates this field value is a synonym of. Empty if the value is not a
        ///                 synonym. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FieldValue </returns>
        public static FieldValueResource Create(string pathAssistantSid,
                                                string pathFieldTypeSid,
                                                string language,
                                                string value,
                                                string synonymOf = null,
                                                ITwilioRestClient client = null)
        {
            var options = new CreateFieldValueOptions(pathAssistantSid, pathFieldTypeSid, language, value){SynonymOf = synonymOf};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathFieldTypeSid"> The field_type_sid </param>
        /// <param name="language"> An ISO language-country string of the value. </param>
        /// <param name="value"> A user-provided string that uniquely identifies this resource as an alternative to the sid.
        ///             Unique up to 64 characters long. </param>
        /// <param name="synonymOf"> A value that indicates this field value is a synonym of. Empty if the value is not a
        ///                 synonym. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<FieldValueResource> CreateAsync(string pathAssistantSid,
                                                                                        string pathFieldTypeSid,
                                                                                        string language,
                                                                                        string value,
                                                                                        string synonymOf = null,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new CreateFieldValueOptions(pathAssistantSid, pathFieldTypeSid, language, value){SynonymOf = synonymOf};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteFieldValueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Preview,
                "/understand/Assistants/" + options.PathAssistantSid + "/FieldTypes/" + options.PathFieldTypeSid + "/FieldValues/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FieldValue </returns>
        public static bool Delete(DeleteFieldValueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete FieldValue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteFieldValueOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathFieldTypeSid"> The field_type_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FieldValue </returns>
        public static bool Delete(string pathAssistantSid,
                                  string pathFieldTypeSid,
                                  string pathSid,
                                  ITwilioRestClient client = null)
        {
            var options = new DeleteFieldValueOptions(pathAssistantSid, pathFieldTypeSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathFieldTypeSid"> The field_type_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FieldValue </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathAssistantSid,
                                                                          string pathFieldTypeSid,
                                                                          string pathSid,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteFieldValueOptions(pathAssistantSid, pathFieldTypeSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a FieldValueResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FieldValueResource object represented by the provided JSON </returns>
        public static FieldValueResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FieldValueResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique ID of the Account that created this Field Value.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The date that this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The unique ID of the Field Type associated with this Field Value.
        /// </summary>
        [JsonProperty("field_type_sid")]
        public string FieldTypeSid { get; private set; }
        /// <summary>
        /// An ISO language-country string of the value.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; private set; }
        /// <summary>
        /// The unique ID of the Assistant.
        /// </summary>
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The Field Value itself.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// A value that indicates this field value is a synonym of. Empty if the value is not a synonym.
        /// </summary>
        [JsonProperty("synonym_of")]
        public string SynonymOf { get; private set; }

        private FieldValueResource()
        {

        }
    }

}