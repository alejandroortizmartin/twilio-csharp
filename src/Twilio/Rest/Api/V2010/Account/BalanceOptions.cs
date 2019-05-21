/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account
{

    /// <summary>
    /// Fetch the balance for an Account based on Account Sid. Balance changes may not be reflected immediately. Child
    /// accounts do not contain balance information
    /// </summary>
    public class FetchBalanceOptions : IOptions<BalanceResource>
    {
        /// <summary>
        /// Account Sid.
        /// </summary>
        public string PathAccountSid { get; set; }

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