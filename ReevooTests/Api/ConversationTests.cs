using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reevoo.Api;
using Shouldly;

namespace ReevooTests.Api
{
    [TestClass]
    public class ConversationTests
    {
        [TestMethod]
        public void Conversation_List_ExpectResults()
        {
            var reevooApi = new ReevooApi();

            // TODO: find valid test arguments
            var response = reevooApi.Conversation.List("D10", "en", "AIPTPDV5700");

            response.conversations.Count.ShouldBe(6);
        }

        [TestMethod]
        public void Conversation_Detail_ExpectResult()
        {
            var reevooApi = new ReevooApi();

            var response = reevooApi.Conversation.Detail(223049);

            response.answers.Count.ShouldBeGreaterThan(0);
        }
    }
}
