/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Studio.V1.Flow.Execution
{

    /// <summary>
    /// Retrieve the most recent context for an Execution.
    /// </summary>
    public class FetchExecutionContextOptions : IOptions<ExecutionContextResource>
    {
        /// <summary>
        /// Flow Sid.
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// Execution Sid.
        /// </summary>
        public string PathExecutionSid { get; }

        /// <summary>
        /// Construct a new FetchExecutionContextOptions
        /// </summary>
        /// <param name="pathFlowSid"> Flow Sid. </param>
        /// <param name="pathExecutionSid"> Execution Sid. </param>
        public FetchExecutionContextOptions(string pathFlowSid, string pathExecutionSid)
        {
            PathFlowSid = pathFlowSid;
            PathExecutionSid = pathExecutionSid;
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

}