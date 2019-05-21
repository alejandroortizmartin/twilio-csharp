/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// StepContextResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Studio.V1.Flow.Engagement.Step
{

    public class StepContextResource : Resource
    {
        private static Request BuildFetchRequest(FetchStepContextOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                "/v1/Flows/" + options.PathFlowSid + "/Engagements/" + options.PathEngagementSid + "/Steps/" + options.PathStepSid + "/Context",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve the context for an Engagement Step.
        /// </summary>
        /// <param name="options"> Fetch StepContext parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of StepContext </returns>
        public static StepContextResource Fetch(FetchStepContextOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieve the context for an Engagement Step.
        /// </summary>
        /// <param name="options"> Fetch StepContext parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of StepContext </returns>
        public static async System.Threading.Tasks.Task<StepContextResource> FetchAsync(FetchStepContextOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieve the context for an Engagement Step.
        /// </summary>
        /// <param name="pathFlowSid"> Flow Sid. </param>
        /// <param name="pathEngagementSid"> Engagement Sid. </param>
        /// <param name="pathStepSid"> Step Sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of StepContext </returns>
        public static StepContextResource Fetch(string pathFlowSid,
                                                string pathEngagementSid,
                                                string pathStepSid,
                                                ITwilioRestClient client = null)
        {
            var options = new FetchStepContextOptions(pathFlowSid, pathEngagementSid, pathStepSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve the context for an Engagement Step.
        /// </summary>
        /// <param name="pathFlowSid"> Flow Sid. </param>
        /// <param name="pathEngagementSid"> Engagement Sid. </param>
        /// <param name="pathStepSid"> Step Sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of StepContext </returns>
        public static async System.Threading.Tasks.Task<StepContextResource> FetchAsync(string pathFlowSid,
                                                                                        string pathEngagementSid,
                                                                                        string pathStepSid,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchStepContextOptions(pathFlowSid, pathEngagementSid, pathStepSid);
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a StepContextResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> StepContextResource object represented by the provided JSON </returns>
        public static StepContextResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<StepContextResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Flow state.
        /// </summary>
        [JsonProperty("context")]
        public object Context { get; private set; }
        /// <summary>
        /// Engagement Sid.
        /// </summary>
        [JsonProperty("engagement_sid")]
        public string EngagementSid { get; private set; }
        /// <summary>
        /// Flow Sid.
        /// </summary>
        [JsonProperty("flow_sid")]
        public string FlowSid { get; private set; }
        /// <summary>
        /// Step Sid.
        /// </summary>
        [JsonProperty("step_sid")]
        public string StepSid { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private StepContextResource()
        {

        }
    }

}