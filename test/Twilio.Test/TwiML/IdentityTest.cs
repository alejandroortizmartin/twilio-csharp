/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NUnit.Framework;
using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;

namespace Twilio.Tests.TwiML
{

    [TestFixture]
    public class IdentityTest : TwilioTest
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Identity();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Identity></Identity>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new Identity("client_identity");
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Identity>client_identity</Identity>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Identity();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Identity newParam1=\"value\" newParam2=\"1\"></Identity>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new Identity();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Identity>Here is the content</Identity>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Identity();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Identity>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Identity>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new Identity();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Identity>before<Child>content</Child>after</Identity>",
                elem.ToString()
            );
        }
    }

}