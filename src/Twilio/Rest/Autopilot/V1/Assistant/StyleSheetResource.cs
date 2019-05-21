/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// StyleSheetResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Autopilot.V1.Assistant
{

    public class StyleSheetResource : Resource
    {
        private static Request BuildFetchRequest(FetchStyleSheetOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/StyleSheet",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Returns Style sheet JSON object for the Assistant
        /// </summary>
        /// <param name="options"> Fetch StyleSheet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of StyleSheet </returns>
        public static StyleSheetResource Fetch(FetchStyleSheetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Returns Style sheet JSON object for the Assistant
        /// </summary>
        /// <param name="options"> Fetch StyleSheet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of StyleSheet </returns>
        public static async System.Threading.Tasks.Task<StyleSheetResource> FetchAsync(FetchStyleSheetOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Returns Style sheet JSON object for the Assistant
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant with the StyleSheet resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of StyleSheet </returns>
        public static StyleSheetResource Fetch(string pathAssistantSid, ITwilioRestClient client = null)
        {
            var options = new FetchStyleSheetOptions(pathAssistantSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns Style sheet JSON object for the Assistant
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant with the StyleSheet resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of StyleSheet </returns>
        public static async System.Threading.Tasks.Task<StyleSheetResource> FetchAsync(string pathAssistantSid,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new FetchStyleSheetOptions(pathAssistantSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateStyleSheetOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/StyleSheet",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Updates the style sheet for an Assistant identified by `assistant_sid`.
        /// </summary>
        /// <param name="options"> Update StyleSheet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of StyleSheet </returns>
        public static StyleSheetResource Update(UpdateStyleSheetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Updates the style sheet for an Assistant identified by `assistant_sid`.
        /// </summary>
        /// <param name="options"> Update StyleSheet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of StyleSheet </returns>
        public static async System.Threading.Tasks.Task<StyleSheetResource> UpdateAsync(UpdateStyleSheetOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Updates the style sheet for an Assistant identified by `assistant_sid`.
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant with the StyleSheet resource to update </param>
        /// <param name="styleSheet"> The JSON string that describes the style sheet object </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of StyleSheet </returns>
        public static StyleSheetResource Update(string pathAssistantSid,
                                                object styleSheet = null,
                                                ITwilioRestClient client = null)
        {
            var options = new UpdateStyleSheetOptions(pathAssistantSid){StyleSheet = styleSheet};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Updates the style sheet for an Assistant identified by `assistant_sid`.
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant with the StyleSheet resource to update </param>
        /// <param name="styleSheet"> The JSON string that describes the style sheet object </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of StyleSheet </returns>
        public static async System.Threading.Tasks.Task<StyleSheetResource> UpdateAsync(string pathAssistantSid,
                                                                                        object styleSheet = null,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new UpdateStyleSheetOptions(pathAssistantSid){StyleSheet = styleSheet};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a StyleSheetResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> StyleSheetResource object represented by the provided JSON </returns>
        public static StyleSheetResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<StyleSheetResource>(json);
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
        /// The SID of the Assistant that is the parent of the resource
        /// </summary>
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }
        /// <summary>
        /// The absolute URL of the StyleSheet resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The JSON string that describes the style sheet object
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; private set; }

        private StyleSheetResource()
        {

        }
    }

}