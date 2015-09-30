using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reevoo.Api;
using Shouldly;

namespace ReevooTests.Api
{
    [TestClass]
    public class ConversationTests
    {
        private readonly TestConfiguration _config;

        public ConversationTests()
        {
            _config = new TestConfiguration();
        }

        [TestMethod]
        public void Conversation_List_ExpectResults()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            // TODO: find valid test arguments
            var response = reevooApi.Conversation.List(_config.Trkref, "en", "AIPTPDV5700");

            response.conversations.Count.ShouldBe(6);
        }

        [TestMethod]
        public void Conversation_Detail_ExpectResult()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            var response = reevooApi.Conversation.Detail(223049);

            response.answers.Count.ShouldBeGreaterThan(0);
        }
    }
}
