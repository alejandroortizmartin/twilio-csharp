/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// AlertResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Monitor.V1
{

    public class AlertResource : Resource
    {
        private static Request BuildFetchRequest(FetchAlertOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Monitor,
                "/v1/Alerts/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Alert parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Alert </returns>
        public static AlertResource Fetch(FetchAlertOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Alert parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Alert </returns>
        public static async System.Threading.Tasks.Task<AlertResource> FetchAsync(FetchAlertOptions options,
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
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Alert </returns>
        public static AlertResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchAlertOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Alert </returns>
        public static async System.Threading.Tasks.Task<AlertResource> FetchAsync(string pathSid,
                                                                                  ITwilioRestClient client = null)
        {
            var options = new FetchAlertOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteAlertOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Monitor,
                "/v1/Alerts/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Alert parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Alert </returns>
        public static bool Delete(DeleteAlertOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Alert parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Alert </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAlertOptions options,
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
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Alert </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAlertOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Alert </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAlertOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadAlertOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Monitor,
                "/v1/Alerts",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Alert parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Alert </returns>
        public static ResourceSet<AlertResource> Read(ReadAlertOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<AlertResource>.FromJson("alerts", response.Content);
            return new ResourceSet<AlertResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Alert parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Alert </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AlertResource>> ReadAsync(ReadAlertOptions options,
                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AlertResource>.FromJson("alerts", response.Content);
            return new ResourceSet<AlertResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="logLevel"> Only show alerts for this log-level. </param>
        /// <param name="startDate"> Only show Alerts on or after this date. </param>
        /// <param name="endDate"> Only show Alerts on or before this date. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Alert </returns>
        public static ResourceSet<AlertResource> Read(string logLevel = null,
                                                      DateTime? startDate = null,
                                                      DateTime? endDate = null,
                                                      int? pageSize = null,
                                                      long? limit = null,
                                                      ITwilioRestClient client = null)
        {
            var options = new ReadAlertOptions(){LogLevel = logLevel, StartDate = startDate, EndDate = endDate, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="logLevel"> Only show alerts for this log-level. </param>
        /// <param name="startDate"> Only show Alerts on or after this date. </param>
        /// <param name="endDate"> Only show Alerts on or before this date. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Alert </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AlertResource>> ReadAsync(string logLevel = null,
                                                                                              DateTime? startDate = null,
                                                                                              DateTime? endDate = null,
                                                                                              int? pageSize = null,
                                                                                              long? limit = null,
                                                                                              ITwilioRestClient client = null)
        {
            var options = new ReadAlertOptions(){LogLevel = logLevel, StartDate = startDate, EndDate = endDate, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AlertResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AlertResource>.FromJson("alerts", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AlertResource> NextPage(Page<AlertResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Monitor,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AlertResource>.FromJson("alerts", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AlertResource> PreviousPage(Page<AlertResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Monitor,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AlertResource>.FromJson("alerts", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a AlertResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AlertResource object represented by the provided JSON </returns>
        public static AlertResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AlertResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique id of the Account responsible for this alert.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The text of the alert.
        /// </summary>
        [JsonProperty("alert_text")]
        public string AlertText { get; private set; }
        /// <summary>
        /// The version of the Twilio API in use when this alert was generated.
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The date that this resource was created, given in ISO 8601 format.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date the alert was actually generated, given in ISO 8601 format.
        /// </summary>
        [JsonProperty("date_generated")]
        public DateTime? DateGenerated { get; private set; }
        /// <summary>
        /// The most recent date that this resource was updated, given in ISO 8601 format.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// A unique error code for the error condition.
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; private set; }
        /// <summary>
        /// A string representing the log level.
        /// </summary>
        [JsonProperty("log_level")]
        public string LogLevel { get; private set; }
        /// <summary>
        /// A URL for more information about the error condition.
        /// </summary>
        [JsonProperty("more_info")]
        public string MoreInfo { get; private set; }
        /// <summary>
        /// If the Alert was generated by a request Twilio made to your server, this will be the request method used when Twilio made the request to your server.
        /// </summary>
        [JsonProperty("request_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod RequestMethod { get; private set; }
        /// <summary>
        /// If the Alert was generated by a request Twilio made to your server, this will be the URL on your server that generated the alert.
        /// </summary>
        [JsonProperty("request_url")]
        public string RequestUrl { get; private set; }
        /// <summary>
        /// The request_variables
        /// </summary>
        [JsonProperty("request_variables")]
        public string RequestVariables { get; private set; }
        /// <summary>
        /// The unique ID of the resource for which the Alert was generated.
        /// </summary>
        [JsonProperty("resource_sid")]
        public string ResourceSid { get; private set; }
        /// <summary>
        /// The response_body
        /// </summary>
        [JsonProperty("response_body")]
        public string ResponseBody { get; private set; }
        /// <summary>
        /// The response_headers
        /// </summary>
        [JsonProperty("response_headers")]
        public string ResponseHeaders { get; private set; }
        /// <summary>
        /// A 34 character string that uniquely identifies this Alert.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The absolute URL for this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private AlertResource()
        {

        }
    }

}