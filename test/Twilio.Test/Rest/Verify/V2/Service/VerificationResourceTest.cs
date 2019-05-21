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
using Twilio.Rest.Verify.V2.Service;

namespace Twilio.Tests.Rest.Verify.V2.Service
{

    [TestFixture]
    public class VerificationTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Verify,
                "/v2/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Verifications",
                ""
            );
            request.AddPostParam("To", Serialize("to"));
            request.AddPostParam("Channel", Serialize("channel"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                VerificationResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "to", "channel", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateVerificationResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"VEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"to\": \"+14159373912\",\"channel\": \"sms\",\"status\": \"pending\",\"valid\": null,\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"lookup\": {\"carrier\": {\"error_code\": null,\"name\": \"Carrier Name\",\"mobile_country_code\": \"310\",\"mobile_network_code\": \"150\",\"type\": \"mobile\"}},\"amount\": \"$29.99\",\"payee\": \"Acme\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Verifications/VEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = VerificationResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "to", "channel", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Verify,
                "/v2/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Verifications/sid",
                ""
            );
            request.AddPostParam("Status", Serialize(VerificationResource.StatusEnum.Canceled));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                VerificationResource.Update("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "sid", VerificationResource.StatusEnum.Canceled, client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateVerificationResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"VEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"to\": \"+14159373912\",\"channel\": \"sms\",\"status\": \"canceled\",\"valid\": null,\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"lookup\": {\"carrier\": {\"error_code\": null,\"name\": \"Carrier Name\",\"mobile_country_code\": \"310\",\"mobile_network_code\": \"150\",\"type\": \"mobile\"}},\"amount\": \"$29.99\",\"payee\": \"Acme\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Verifications/VEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = VerificationResource.Update("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "sid", VerificationResource.StatusEnum.Canceled, client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Verify,
                "/v2/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Verifications/sid",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                VerificationResource.Fetch("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "sid", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchVerificationResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"VEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"to\": \"+14159373912\",\"channel\": \"sms\",\"status\": \"pending\",\"valid\": null,\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"lookup\": {\"carrier\": {\"error_code\": null,\"name\": \"Carrier Name\",\"mobile_country_code\": \"310\",\"mobile_network_code\": \"150\",\"type\": \"mobile\"}},\"amount\": \"$29.99\",\"payee\": \"Acme\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Verifications/VEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = VerificationResource.Fetch("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "sid", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}