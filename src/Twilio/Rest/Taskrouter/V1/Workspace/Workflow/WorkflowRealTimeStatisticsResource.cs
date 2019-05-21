/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// WorkflowRealTimeStatisticsResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Workflow
{

    public class WorkflowRealTimeStatisticsResource : Resource
    {
        private static Request BuildFetchRequest(FetchWorkflowRealTimeStatisticsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Workflows/" + options.PathWorkflowSid + "/RealTimeStatistics",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch WorkflowRealTimeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkflowRealTimeStatistics </returns>
        public static WorkflowRealTimeStatisticsResource Fetch(FetchWorkflowRealTimeStatisticsOptions options,
                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch WorkflowRealTimeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkflowRealTimeStatistics </returns>
        public static async System.Threading.Tasks.Task<WorkflowRealTimeStatisticsResource> FetchAsync(FetchWorkflowRealTimeStatisticsOptions options,
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
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathWorkflowSid"> The workflow_sid </param>
        /// <param name="taskChannel"> Filter real-time and cumulative statistics by TaskChannel. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkflowRealTimeStatistics </returns>
        public static WorkflowRealTimeStatisticsResource Fetch(string pathWorkspaceSid,
                                                               string pathWorkflowSid,
                                                               string taskChannel = null,
                                                               ITwilioRestClient client = null)
        {
            var options = new FetchWorkflowRealTimeStatisticsOptions(pathWorkspaceSid, pathWorkflowSid){TaskChannel = taskChannel};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathWorkflowSid"> The workflow_sid </param>
        /// <param name="taskChannel"> Filter real-time and cumulative statistics by TaskChannel. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkflowRealTimeStatistics </returns>
        public static async System.Threading.Tasks.Task<WorkflowRealTimeStatisticsResource> FetchAsync(string pathWorkspaceSid,
                                                                                                       string pathWorkflowSid,
                                                                                                       string taskChannel = null,
                                                                                                       ITwilioRestClient client = null)
        {
            var options = new FetchWorkflowRealTimeStatisticsOptions(pathWorkspaceSid, pathWorkflowSid){TaskChannel = taskChannel};
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a WorkflowRealTimeStatisticsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkflowRealTimeStatisticsResource object represented by the provided JSON </returns>
        public static WorkflowRealTimeStatisticsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<WorkflowRealTimeStatisticsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The age of the longest waiting Task
        /// </summary>
        [JsonProperty("longest_task_waiting_age")]
        public int? LongestTaskWaitingAge { get; private set; }
        /// <summary>
        /// The SID of the longest waiting Task
        /// </summary>
        [JsonProperty("longest_task_waiting_sid")]
        public string LongestTaskWaitingSid { get; private set; }
        /// <summary>
        /// The tasks_by_priority
        /// </summary>
        [JsonProperty("tasks_by_priority")]
        public object TasksByPriority { get; private set; }
        /// <summary>
        /// The Tasks broken down by status
        /// </summary>
        [JsonProperty("tasks_by_status")]
        public object TasksByStatus { get; private set; }
        /// <summary>
        /// The total number of Tasks
        /// </summary>
        [JsonProperty("total_tasks")]
        public int? TotalTasks { get; private set; }
        /// <summary>
        /// The workflow_sid
        /// </summary>
        [JsonProperty("workflow_sid")]
        public string WorkflowSid { get; private set; }
        /// <summary>
        /// The workspace_sid
        /// </summary>
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private WorkflowRealTimeStatisticsResource()
        {

        }
    }

}