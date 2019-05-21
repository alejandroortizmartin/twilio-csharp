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
    public class ParameterTest : TwilioTest
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Parameter();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Parameter></Parameter>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new Parameter("name", "value");
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Parameter name=\"name\" value=\"value\"></Parameter>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Parameter();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Parameter newParam1=\"value\" newParam2=\"1\"></Parameter>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new Parameter();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Parameter>Here is the content</Parameter>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Parameter();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Parameter>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Parameter>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new Parameter();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Parameter>before<Child>content</Child>after</Parameter>",
                elem.ToString()
            );
        }
    }

}