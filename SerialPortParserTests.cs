using System;
using NUnit.Framework;

namespace BasicTDD.Tests
{
    [TestFixture]
    public class SerialPortParserTests
    {
        [Test]
        public void ParsePort_COM1_Reurns1()
        {
            int result = SerialPortParser.ParsePort("COM1");
            Assert.That(result, Is.EqualTo(1));

        }
        
        [Test]
        public void ParsePort_InvalidFormat_ThrowsInvalidFormatException()
        {
            void action() => SerialPortParser.ParsePort("1");
            Assert.Throws<FormatException>(action);
            
        }
    }
}