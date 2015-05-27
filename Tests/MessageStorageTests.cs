using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class MessageStorageTests
    {
        [TestMethod]
        public void SetAndGetMessage()
        {
            Messaging.MessageStorage.RecordMessage("luke", "message");

            var result = Messaging.MessageStorage.GetTenMessages();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any(a => a.Name == "luke" && a.MessageText == "message"));
        }
    }
}
