/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.Understand.Assistant.Task
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Returns JSON actions for this Task.
    /// </summary>
    public class FetchTaskActionsOptions : IOptions<TaskActionsResource>
    {
        /// <summary>
        /// The unique ID of the parent Assistant.
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The unique ID of the Task.
        /// </summary>
        public string PathTaskSid { get; }

        /// <summary>
        /// Construct a new FetchTaskActionsOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        /// <param name="pathTaskSid"> The unique ID of the Task. </param>
        public FetchTaskActionsOptions(string pathAssistantSid, string pathTaskSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Updates the actions of an Task identified by {TaskSid} or {TaskUniqueName}.
    /// </summary>
    public class UpdateTaskActionsOptions : IOptions<TaskActionsResource>
    {
        /// <summary>
        /// The unique ID of the parent Assistant.
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The unique ID of the Task.
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The JSON actions that instruct the Assistant how to perform this task.
        /// </summary>
        public object Actions { get; set; }

        /// <summary>
        /// Construct a new UpdateTaskActionsOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        /// <param name="pathTaskSid"> The unique ID of the Task. </param>
        public UpdateTaskActionsOptions(string pathAssistantSid, string pathTaskSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Actions != null)
            {
                p.Add(new KeyValuePair<string, string>("Actions", Serializers.JsonObject(Actions)));
            }

            return p;
        }
    }

}