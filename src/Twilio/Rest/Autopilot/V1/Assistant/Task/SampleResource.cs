/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// SampleResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Autopilot.V1.Assistant.Task
{

    public class SampleResource : Resource
    {
        private static Request BuildFetchRequest(FetchSampleOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Tasks/" + options.PathTaskSid + "/Samples/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Sample parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sample </returns>
        public static SampleResource Fetch(FetchSampleOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Sample parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sample </returns>
        public static async System.Threading.Tasks.Task<SampleResource> FetchAsync(FetchSampleOptions options,
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
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resource to fetch </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resource to create </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sample </returns>
        public static SampleResource Fetch(string pathAssistantSid,
                                           string pathTaskSid,
                                           string pathSid,
                                           ITwilioRestClient client = null)
        {
            var options = new FetchSampleOptions(pathAssistantSid, pathTaskSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resource to fetch </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resource to create </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sample </returns>
        public static async System.Threading.Tasks.Task<SampleResource> FetchAsync(string pathAssistantSid,
                                                                                   string pathTaskSid,
                                                                                   string pathSid,
                                                                                   ITwilioRestClient client = null)
        {
            var options = new FetchSampleOptions(pathAssistantSid, pathTaskSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadSampleOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Tasks/" + options.PathTaskSid + "/Samples",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Sample parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sample </returns>
        public static ResourceSet<SampleResource> Read(ReadSampleOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<SampleResource>.FromJson("samples", response.Content);
            return new ResourceSet<SampleResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Sample parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sample </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SampleResource>> ReadAsync(ReadSampleOptions options,
                                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SampleResource>.FromJson("samples", response.Content);
            return new ResourceSet<SampleResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resources to read </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resources to read </param>
        /// <param name="language"> The ISO language-country string that specifies the language used for the sample </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sample </returns>
        public static ResourceSet<SampleResource> Read(string pathAssistantSid,
                                                       string pathTaskSid,
                                                       string language = null,
                                                       int? pageSize = null,
                                                       long? limit = null,
                                                       ITwilioRestClient client = null)
        {
            var options = new ReadSampleOptions(pathAssistantSid, pathTaskSid){Language = language, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resources to read </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resources to read </param>
        /// <param name="language"> The ISO language-country string that specifies the language used for the sample </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sample </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SampleResource>> ReadAsync(string pathAssistantSid,
                                                                                               string pathTaskSid,
                                                                                               string language = null,
                                                                                               int? pageSize = null,
                                                                                               long? limit = null,
                                                                                               ITwilioRestClient client = null)
        {
            var options = new ReadSampleOptions(pathAssistantSid, pathTaskSid){Language = language, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SampleResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SampleResource>.FromJson("samples", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SampleResource> NextPage(Page<SampleResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Autopilot,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<SampleResource>.FromJson("samples", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SampleResource> PreviousPage(Page<SampleResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Autopilot,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<SampleResource>.FromJson("samples", response.Content);
        }

        private static Request BuildCreateRequest(CreateSampleOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Tasks/" + options.PathTaskSid + "/Samples",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Sample parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sample </returns>
        public static SampleResource Create(CreateSampleOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Sample parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sample </returns>
        public static async System.Threading.Tasks.Task<SampleResource> CreateAsync(CreateSampleOptions options,
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
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the new
        ///                        resource </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resource to create </param>
        /// <param name="language"> The ISO language-country string that specifies the language used for the new sample </param>
        /// <param name="taggedText"> The text example of how end users might express the task </param>
        /// <param name="sourceChannel"> The communication channel from which the new sample was captured </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sample </returns>
        public static SampleResource Create(string pathAssistantSid,
                                            string pathTaskSid,
                                            string language,
                                            string taggedText,
                                            string sourceChannel = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateSampleOptions(pathAssistantSid, pathTaskSid, language, taggedText){SourceChannel = sourceChannel};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the new
        ///                        resource </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resource to create </param>
        /// <param name="language"> The ISO language-country string that specifies the language used for the new sample </param>
        /// <param name="taggedText"> The text example of how end users might express the task </param>
        /// <param name="sourceChannel"> The communication channel from which the new sample was captured </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sample </returns>
        public static async System.Threading.Tasks.Task<SampleResource> CreateAsync(string pathAssistantSid,
                                                                                    string pathTaskSid,
                                                                                    string language,
                                                                                    string taggedText,
                                                                                    string sourceChannel = null,
                                                                                    ITwilioRestClient client = null)
        {
            var options = new CreateSampleOptions(pathAssistantSid, pathTaskSid, language, taggedText){SourceChannel = sourceChannel};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateSampleOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Tasks/" + options.PathTaskSid + "/Samples/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Sample parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sample </returns>
        public static SampleResource Update(UpdateSampleOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Sample parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sample </returns>
        public static async System.Threading.Tasks.Task<SampleResource> UpdateAsync(UpdateSampleOptions options,
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resource to update </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resource to update </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="language"> The ISO language-country string that specifies the language used for the sample </param>
        /// <param name="taggedText"> The text example of how end users might express the task </param>
        /// <param name="sourceChannel"> The communication channel from which the sample was captured </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sample </returns>
        public static SampleResource Update(string pathAssistantSid,
                                            string pathTaskSid,
                                            string pathSid,
                                            string language = null,
                                            string taggedText = null,
                                            string sourceChannel = null,
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateSampleOptions(pathAssistantSid, pathTaskSid, pathSid){Language = language, TaggedText = taggedText, SourceChannel = sourceChannel};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resource to update </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resource to update </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="language"> The ISO language-country string that specifies the language used for the sample </param>
        /// <param name="taggedText"> The text example of how end users might express the task </param>
        /// <param name="sourceChannel"> The communication channel from which the sample was captured </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sample </returns>
        public static async System.Threading.Tasks.Task<SampleResource> UpdateAsync(string pathAssistantSid,
                                                                                    string pathTaskSid,
                                                                                    string pathSid,
                                                                                    string language = null,
                                                                                    string taggedText = null,
                                                                                    string sourceChannel = null,
                                                                                    ITwilioRestClient client = null)
        {
            var options = new UpdateSampleOptions(pathAssistantSid, pathTaskSid, pathSid){Language = language, TaggedText = taggedText, SourceChannel = sourceChannel};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteSampleOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Tasks/" + options.PathTaskSid + "/Samples/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Sample parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sample </returns>
        public static bool Delete(DeleteSampleOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Sample parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sample </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSampleOptions options,
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
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resources to delete </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resource to delete </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sample </returns>
        public static bool Delete(string pathAssistantSid,
                                  string pathTaskSid,
                                  string pathSid,
                                  ITwilioRestClient client = null)
        {
            var options = new DeleteSampleOptions(pathAssistantSid, pathTaskSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task associated with the
        ///                        resources to delete </param>
        /// <param name="pathTaskSid"> The SID of the Task associated with the Sample resource to delete </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sample </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathAssistantSid,
                                                                          string pathTaskSid,
                                                                          string pathSid,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteSampleOptions(pathAssistantSid, pathTaskSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a SampleResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SampleResource object represented by the provided JSON </returns>
        public static SampleResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SampleResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The SID of the Task associated with the resource
        /// </summary>
        [JsonProperty("task_sid")]
        public string TaskSid { get; private set; }
        /// <summary>
        /// An ISO language-country string that specifies the language used for the sample
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; private set; }
        /// <summary>
        /// The SID of the Assistant that is the parent of the Task associated with the resource
        /// </summary>
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The text example of how end users might express the task
        /// </summary>
        [JsonProperty("tagged_text")]
        public string TaggedText { get; private set; }
        /// <summary>
        /// The absolute URL of the Sample resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The communication channel from which the sample was captured
        /// </summary>
        [JsonProperty("source_channel")]
        public string SourceChannel { get; private set; }

        private SampleResource()
        {

        }
    }

}