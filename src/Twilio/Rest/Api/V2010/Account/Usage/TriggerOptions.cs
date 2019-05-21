/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Usage
{

    /// <summary>
    /// Fetch and instance of a usage-trigger
    /// </summary>
    public class FetchTriggerOptions : IOptions<TriggerResource>
    {
        /// <summary>
        /// The SID of the Account that created the resource to fetch
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchTriggerOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchTriggerOptions(string pathSid)
        {
            PathSid = pathSid;
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
    /// Update an instance of a usage trigger
    /// </summary>
    public class UpdateTriggerOptions : IOptions<TriggerResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to update
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The HTTP method to use to call callback_url
        /// </summary>
        public Twilio.Http.HttpMethod CallbackMethod { get; set; }
        /// <summary>
        /// The URL we call when the trigger fires
        /// </summary>
        public Uri CallbackUrl { get; set; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new UpdateTriggerOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public UpdateTriggerOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (CallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackMethod", CallbackMethod.ToString()));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", Serializers.Url(CallbackUrl)));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteTriggerOptions
    /// </summary>
    public class DeleteTriggerOptions : IOptions<TriggerResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to delete
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteTriggerOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteTriggerOptions(string pathSid)
        {
            PathSid = pathSid;
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
    /// Create a new UsageTrigger
    /// </summary>
    public class CreateTriggerOptions : IOptions<TriggerResource>
    {
        /// <summary>
        /// The SID of the Account that will create the resource
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The URL we call when the trigger fires
        /// </summary>
        public Uri CallbackUrl { get; }
        /// <summary>
        /// The usage value at which the trigger should fire
        /// </summary>
        public string TriggerValue { get; }
        /// <summary>
        /// The usage category the trigger watches
        /// </summary>
        public TriggerResource.UsageCategoryEnum UsageCategory { get; }
        /// <summary>
        /// The HTTP method to use to call callback_url
        /// </summary>
        public Twilio.Http.HttpMethod CallbackMethod { get; set; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The frequency of a recurring UsageTrigger
        /// </summary>
        public TriggerResource.RecurringEnum Recurring { get; set; }
        /// <summary>
        /// The field in the UsageRecord resource that fires the trigger
        /// </summary>
        public TriggerResource.TriggerFieldEnum TriggerBy { get; set; }

        /// <summary>
        /// Construct a new CreateTriggerOptions
        /// </summary>
        /// <param name="callbackUrl"> The URL we call when the trigger fires </param>
        /// <param name="triggerValue"> The usage value at which the trigger should fire </param>
        /// <param name="usageCategory"> The usage category the trigger watches </param>
        public CreateTriggerOptions(Uri callbackUrl, string triggerValue, TriggerResource.UsageCategoryEnum usageCategory)
        {
            CallbackUrl = callbackUrl;
            TriggerValue = triggerValue;
            UsageCategory = usageCategory;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", Serializers.Url(CallbackUrl)));
            }

            if (TriggerValue != null)
            {
                p.Add(new KeyValuePair<string, string>("TriggerValue", TriggerValue));
            }

            if (UsageCategory != null)
            {
                p.Add(new KeyValuePair<string, string>("UsageCategory", UsageCategory.ToString()));
            }

            if (CallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackMethod", CallbackMethod.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Recurring != null)
            {
                p.Add(new KeyValuePair<string, string>("Recurring", Recurring.ToString()));
            }

            if (TriggerBy != null)
            {
                p.Add(new KeyValuePair<string, string>("TriggerBy", TriggerBy.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of usage-triggers belonging to the account used to make the request
    /// </summary>
    public class ReadTriggerOptions : ReadOptions<TriggerResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to read
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The frequency of recurring UsageTriggers to read
        /// </summary>
        public TriggerResource.RecurringEnum Recurring { get; set; }
        /// <summary>
        /// The trigger field of the UsageTriggers to read
        /// </summary>
        public TriggerResource.TriggerFieldEnum TriggerBy { get; set; }
        /// <summary>
        /// The usage category of the UsageTriggers to read
        /// </summary>
        public TriggerResource.UsageCategoryEnum UsageCategory { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Recurring != null)
            {
                p.Add(new KeyValuePair<string, string>("Recurring", Recurring.ToString()));
            }

            if (TriggerBy != null)
            {
                p.Add(new KeyValuePair<string, string>("TriggerBy", TriggerBy.ToString()));
            }

            if (UsageCategory != null)
            {
                p.Add(new KeyValuePair<string, string>("UsageCategory", UsageCategory.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}