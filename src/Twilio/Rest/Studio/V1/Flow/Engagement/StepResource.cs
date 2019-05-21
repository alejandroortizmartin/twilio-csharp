/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// StepResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Studio.V1.Flow.Engagement
{

    public class StepResource : Resource
    {
        private static Request BuildReadRequest(ReadStepOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                "/v1/Flows/" + options.PathFlowSid + "/Engagements/" + options.PathEngagementSid + "/Steps",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Steps for an Engagement.
        /// </summary>
        /// <param name="options"> Read Step parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Step </returns>
        public static ResourceSet<StepResource> Read(ReadStepOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<StepResource>.FromJson("steps", response.Content);
            return new ResourceSet<StepResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Steps for an Engagement.
        /// </summary>
        /// <param name="options"> Read Step parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Step </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<StepResource>> ReadAsync(ReadStepOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<StepResource>.FromJson("steps", response.Content);
            return new ResourceSet<StepResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Steps for an Engagement.
        /// </summary>
        /// <param name="pathFlowSid"> Flow Sid. </param>
        /// <param name="pathEngagementSid"> Engagement Sid. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Step </returns>
        public static ResourceSet<StepResource> Read(string pathFlowSid,
                                                     string pathEngagementSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadStepOptions(pathFlowSid, pathEngagementSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Steps for an Engagement.
        /// </summary>
        /// <param name="pathFlowSid"> Flow Sid. </param>
        /// <param name="pathEngagementSid"> Engagement Sid. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Step </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<StepResource>> ReadAsync(string pathFlowSid,
                                                                                             string pathEngagementSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadStepOptions(pathFlowSid, pathEngagementSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<StepResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<StepResource>.FromJson("steps", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<StepResource> NextPage(Page<StepResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Studio,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<StepResource>.FromJson("steps", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<StepResource> PreviousPage(Page<StepResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Studio,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<StepResource>.FromJson("steps", response.Content);
        }

        private static Request BuildFetchRequest(FetchStepOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                "/v1/Flows/" + options.PathFlowSid + "/Engagements/" + options.PathEngagementSid + "/Steps/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a Step.
        /// </summary>
        /// <param name="options"> Fetch Step parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Step </returns>
        public static StepResource Fetch(FetchStepOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a Step.
        /// </summary>
        /// <param name="options"> Fetch Step parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Step </returns>
        public static async System.Threading.Tasks.Task<StepResource> FetchAsync(FetchStepOptions options,
                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieve a Step.
        /// </summary>
        /// <param name="pathFlowSid"> Flow Sid. </param>
        /// <param name="pathEngagementSid"> Engagement Sid. </param>
        /// <param name="pathSid"> Step Sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Step </returns>
        public static StepResource Fetch(string pathFlowSid,
                                         string pathEngagementSid,
                                         string pathSid,
                                         ITwilioRestClient client = null)
        {
            var options = new FetchStepOptions(pathFlowSid, pathEngagementSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a Step.
        /// </summary>
        /// <param name="pathFlowSid"> Flow Sid. </param>
        /// <param name="pathEngagementSid"> Engagement Sid. </param>
        /// <param name="pathSid"> Step Sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Step </returns>
        public static async System.Threading.Tasks.Task<StepResource> FetchAsync(string pathFlowSid,
                                                                                 string pathEngagementSid,
                                                                                 string pathSid,
                                                                                 ITwilioRestClient client = null)
        {
            var options = new FetchStepOptions(pathFlowSid, pathEngagementSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a StepResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> StepResource object represented by the provided JSON </returns>
        public static StepResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<StepResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Step.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Flow Sid.
        /// </summary>
        [JsonProperty("flow_sid")]
        public string FlowSid { get; private set; }
        /// <summary>
        /// Engagement Sid.
        /// </summary>
        [JsonProperty("engagement_sid")]
        public string EngagementSid { get; private set; }
        /// <summary>
        /// The event that caused the flow to transition to this Step.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
        /// <summary>
        /// The context
        /// </summary>
        [JsonProperty("context")]
        public object Context { get; private set; }
        /// <summary>
        /// The Widget that preceded the Widget for this Step.
        /// </summary>
        [JsonProperty("transitioned_from")]
        public string TransitionedFrom { get; private set; }
        /// <summary>
        /// The Widget that will follow the Widget for this Step.
        /// </summary>
        [JsonProperty("transitioned_to")]
        public string TransitionedTo { get; private set; }
        /// <summary>
        /// The date this Step was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Step was updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private StepResource()
        {

        }
    }

}