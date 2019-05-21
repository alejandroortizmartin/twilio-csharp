/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Taskrouter.V1.Workspace.Worker;

namespace Twilio.Tests.Rest.Taskrouter.V1.Workspace.Worker
{

    [TestFixture]
    public class WorkersRealTimeStatisticsTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Taskrouter,
                "/v1/Workspaces/WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Workers/RealTimeStatistics",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                WorkersRealTimeStatisticsResource.Fetch("WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workers/RealTimeStatistics\",\"total_workers\": 15,\"activity_statistics\": [{\"friendly_name\": \"Idle\",\"workers\": 0,\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},{\"friendly_name\": \"Busy\",\"workers\": 9,\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},{\"friendly_name\": \"Offline\",\"workers\": 6,\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},{\"friendly_name\": \"Reserved\",\"workers\": 0,\"sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}]}"
                                     ));

            var response = WorkersRealTimeStatisticsResource.Fetch("WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}