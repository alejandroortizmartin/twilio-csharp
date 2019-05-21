/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// MessageResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.IpMessaging.V2.Service.Channel
{

    public class MessageResource : Resource
    {
        public sealed class OrderTypeEnum : StringEnum
        {
            private OrderTypeEnum(string value) : base(value) {}
            public OrderTypeEnum() {}
            public static implicit operator OrderTypeEnum(string value)
            {
                return new OrderTypeEnum(value);
            }

            public static readonly OrderTypeEnum Asc = new OrderTypeEnum("asc");
            public static readonly OrderTypeEnum Desc = new OrderTypeEnum("desc");
        }

        public sealed class WebhookEnabledTypeEnum : StringEnum
        {
            private WebhookEnabledTypeEnum(string value) : base(value) {}
            public WebhookEnabledTypeEnum() {}
            public static implicit operator WebhookEnabledTypeEnum(string value)
            {
                return new WebhookEnabledTypeEnum(value);
            }

            public static readonly WebhookEnabledTypeEnum True = new WebhookEnabledTypeEnum("true");
            public static readonly WebhookEnabledTypeEnum False = new WebhookEnabledTypeEnum("false");
        }

        private static Request BuildFetchRequest(FetchMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathChannelSid + "/Messages/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Fetch(FetchMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> FetchAsync(FetchMessageOptions options,
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
        /// <param name="pathServiceSid"> The SID of the Service to fetch the resource from </param>
        /// <param name="pathChannelSid"> The unique ID of the Channel the message to fetch belongs to </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Fetch(string pathServiceSid,
                                            string pathChannelSid,
                                            string pathSid,
                                            ITwilioRestClient client = null)
        {
            var options = new FetchMessageOptions(pathServiceSid, pathChannelSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the resource from </param>
        /// <param name="pathChannelSid"> The unique ID of the Channel the message to fetch belongs to </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> FetchAsync(string pathServiceSid,
                                                                                    string pathChannelSid,
                                                                                    string pathSid,
                                                                                    ITwilioRestClient client = null)
        {
            var options = new FetchMessageOptions(pathServiceSid, pathChannelSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathChannelSid + "/Messages",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Create(CreateMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> CreateAsync(CreateMessageOptions options,
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
        /// <param name="pathServiceSid"> The SID of the Service to create the resource under </param>
        /// <param name="pathChannelSid"> The unique ID of the channel the new resource belongs to </param>
        /// <param name="from"> The identity of the new message's author </param>
        /// <param name="attributes"> A valid JSON string that contains application-specific data </param>
        /// <param name="dateCreated"> The ISO 8601 date and time in GMT when the resource was created </param>
        /// <param name="dateUpdated"> The ISO 8601 date and time in GMT when the resource was updated </param>
        /// <param name="lastUpdatedBy"> The Identity of the User who last updated the Message </param>
        /// <param name="body"> The message to send to the channel </param>
        /// <param name="mediaSid">  The Media Sid to be attached to the new Message </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Create(string pathServiceSid,
                                             string pathChannelSid,
                                             string from = null,
                                             string attributes = null,
                                             DateTime? dateCreated = null,
                                             DateTime? dateUpdated = null,
                                             string lastUpdatedBy = null,
                                             string body = null,
                                             string mediaSid = null,
                                             ITwilioRestClient client = null)
        {
            var options = new CreateMessageOptions(pathServiceSid, pathChannelSid){From = from, Attributes = attributes, DateCreated = dateCreated, DateUpdated = dateUpdated, LastUpdatedBy = lastUpdatedBy, Body = body, MediaSid = mediaSid};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the resource under </param>
        /// <param name="pathChannelSid"> The unique ID of the channel the new resource belongs to </param>
        /// <param name="from"> The identity of the new message's author </param>
        /// <param name="attributes"> A valid JSON string that contains application-specific data </param>
        /// <param name="dateCreated"> The ISO 8601 date and time in GMT when the resource was created </param>
        /// <param name="dateUpdated"> The ISO 8601 date and time in GMT when the resource was updated </param>
        /// <param name="lastUpdatedBy"> The Identity of the User who last updated the Message </param>
        /// <param name="body"> The message to send to the channel </param>
        /// <param name="mediaSid">  The Media Sid to be attached to the new Message </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> CreateAsync(string pathServiceSid,
                                                                                     string pathChannelSid,
                                                                                     string from = null,
                                                                                     string attributes = null,
                                                                                     DateTime? dateCreated = null,
                                                                                     DateTime? dateUpdated = null,
                                                                                     string lastUpdatedBy = null,
                                                                                     string body = null,
                                                                                     string mediaSid = null,
                                                                                     ITwilioRestClient client = null)
        {
            var options = new CreateMessageOptions(pathServiceSid, pathChannelSid){From = from, Attributes = attributes, DateCreated = dateCreated, DateUpdated = dateUpdated, LastUpdatedBy = lastUpdatedBy, Body = body, MediaSid = mediaSid};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathChannelSid + "/Messages",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static ResourceSet<MessageResource> Read(ReadMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<MessageResource>.FromJson("messages", response.Content);
            return new ResourceSet<MessageResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MessageResource>> ReadAsync(ReadMessageOptions options,
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<MessageResource>.FromJson("messages", response.Content);
            return new ResourceSet<MessageResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the resources from </param>
        /// <param name="pathChannelSid"> The unique ID of the Channel the message to read belongs to </param>
        /// <param name="order"> The sort order of the returned messages </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static ResourceSet<MessageResource> Read(string pathServiceSid,
                                                        string pathChannelSid,
                                                        MessageResource.OrderTypeEnum order = null,
                                                        int? pageSize = null,
                                                        long? limit = null,
                                                        ITwilioRestClient client = null)
        {
            var options = new ReadMessageOptions(pathServiceSid, pathChannelSid){Order = order, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the resources from </param>
        /// <param name="pathChannelSid"> The unique ID of the Channel the message to read belongs to </param>
        /// <param name="order"> The sort order of the returned messages </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MessageResource>> ReadAsync(string pathServiceSid,
                                                                                                string pathChannelSid,
                                                                                                MessageResource.OrderTypeEnum order = null,
                                                                                                int? pageSize = null,
                                                                                                long? limit = null,
                                                                                                ITwilioRestClient client = null)
        {
            var options = new ReadMessageOptions(pathServiceSid, pathChannelSid){Order = order, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<MessageResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<MessageResource> NextPage(Page<MessageResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.IpMessaging,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<MessageResource> PreviousPage(Page<MessageResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.IpMessaging,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }

        private static Request BuildDeleteRequest(DeleteMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathChannelSid + "/Messages/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static bool Delete(DeleteMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteMessageOptions options,
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
        /// <param name="pathServiceSid"> The SID of the Service to delete the resource from </param>
        /// <param name="pathChannelSid"> The unique ID of the channel the message to delete belongs to </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static bool Delete(string pathServiceSid,
                                  string pathChannelSid,
                                  string pathSid,
                                  ITwilioRestClient client = null)
        {
            var options = new DeleteMessageOptions(pathServiceSid, pathChannelSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the resource from </param>
        /// <param name="pathChannelSid"> The unique ID of the channel the message to delete belongs to </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid,
                                                                          string pathChannelSid,
                                                                          string pathSid,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteMessageOptions(pathServiceSid, pathChannelSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.IpMessaging,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathChannelSid + "/Messages/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Update(UpdateMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> UpdateAsync(UpdateMessageOptions options,
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
        /// <param name="pathServiceSid"> The SID of the Service to update the resource from </param>
        /// <param name="pathChannelSid"> The unique ID of the Channel the message belongs to </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="body"> The message to send to the channel </param>
        /// <param name="attributes"> A valid JSON string that contains application-specific data </param>
        /// <param name="dateCreated"> The ISO 8601 date and time in GMT when the resource was created </param>
        /// <param name="dateUpdated"> The ISO 8601 date and time in GMT when the resource was updated </param>
        /// <param name="lastUpdatedBy"> The Identity of the User who last updated the Message, if applicable </param>
        /// <param name="from"> The identity of the message's author </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Update(string pathServiceSid,
                                             string pathChannelSid,
                                             string pathSid,
                                             string body = null,
                                             string attributes = null,
                                             DateTime? dateCreated = null,
                                             DateTime? dateUpdated = null,
                                             string lastUpdatedBy = null,
                                             string from = null,
                                             ITwilioRestClient client = null)
        {
            var options = new UpdateMessageOptions(pathServiceSid, pathChannelSid, pathSid){Body = body, Attributes = attributes, DateCreated = dateCreated, DateUpdated = dateUpdated, LastUpdatedBy = lastUpdatedBy, From = from};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to update the resource from </param>
        /// <param name="pathChannelSid"> The unique ID of the Channel the message belongs to </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="body"> The message to send to the channel </param>
        /// <param name="attributes"> A valid JSON string that contains application-specific data </param>
        /// <param name="dateCreated"> The ISO 8601 date and time in GMT when the resource was created </param>
        /// <param name="dateUpdated"> The ISO 8601 date and time in GMT when the resource was updated </param>
        /// <param name="lastUpdatedBy"> The Identity of the User who last updated the Message, if applicable </param>
        /// <param name="from"> The identity of the message's author </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> UpdateAsync(string pathServiceSid,
                                                                                     string pathChannelSid,
                                                                                     string pathSid,
                                                                                     string body = null,
                                                                                     string attributes = null,
                                                                                     DateTime? dateCreated = null,
                                                                                     DateTime? dateUpdated = null,
                                                                                     string lastUpdatedBy = null,
                                                                                     string from = null,
                                                                                     ITwilioRestClient client = null)
        {
            var options = new UpdateMessageOptions(pathServiceSid, pathChannelSid, pathSid){Body = body, Attributes = attributes, DateCreated = dateCreated, DateUpdated = dateUpdated, LastUpdatedBy = lastUpdatedBy, From = from};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a MessageResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MessageResource object represented by the provided JSON </returns>
        public static MessageResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<MessageResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The JSON string that stores application-specific data
        /// </summary>
        [JsonProperty("attributes")]
        public string Attributes { get; private set; }
        /// <summary>
        /// The SID of the Service that the resource is associated with
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The SID of the Channel that the message was sent to
        /// </summary>
        [JsonProperty("to")]
        public string To { get; private set; }
        /// <summary>
        /// The unique ID of the Channel the Message resource belongs to
        /// </summary>
        [JsonProperty("channel_sid")]
        public string ChannelSid { get; private set; }
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
        /// The Identity of the User who last updated the Message
        /// </summary>
        [JsonProperty("last_updated_by")]
        public string LastUpdatedBy { get; private set; }
        /// <summary>
        /// Whether the message has been edited since  it was created
        /// </summary>
        [JsonProperty("was_edited")]
        public bool? WasEdited { get; private set; }
        /// <summary>
        /// The identity of the message's author
        /// </summary>
        [JsonProperty("from")]
        public string From { get; private set; }
        /// <summary>
        /// The content of the message
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; private set; }
        /// <summary>
        /// The index of the message within the Channel
        /// </summary>
        [JsonProperty("index")]
        public int? Index { get; private set; }
        /// <summary>
        /// The Message type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }
        /// <summary>
        /// A Media object that describes the Message's media if attached; otherwise, null
        /// </summary>
        [JsonProperty("media")]
        public object Media { get; private set; }
        /// <summary>
        /// The absolute URL of the Message resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private MessageResource()
        {

        }
    }

}