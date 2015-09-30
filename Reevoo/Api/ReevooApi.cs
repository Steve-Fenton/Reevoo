using System;

namespace Reevoo.Api
{
    public class ReevooApi
    {
        private readonly string Key;
        private readonly string Secret;
        private readonly Uri BaseUri;

        public ReevooApi()
        {
            var configuration = new Configuration();
            Key = configuration.Key;
            Secret = configuration.Secret;
            BaseUri = new Uri(configuration.BaseUri);
        }

        public ReevooApi(string key, string secret, string baseUri = "https://api.reevoocloud.com/")
        {
            Key = key;
            Secret = secret;
            BaseUri = new Uri(baseUri);
        }

        public OrganisationApi Organisation
        {
            get
            {
                return new OrganisationApi(Key, Secret, BaseUri);
            }
        }

        public ReviewableApi Reviewable
        {
            get
            {
                return new ReviewableApi(Key, Secret, BaseUri);
            }
        }

        public ReviewApi Review
        {
            get
            {
                return new ReviewApi(Key, Secret, BaseUri);
            }
        }

        public CustomerExperienceReviewApi CustomerExperienceReview
        {
            get
            {
                return new CustomerExperienceReviewApi(Key, Secret, BaseUri);
            }
        }

        public ConversationApi Conversation
        {
            get
            {
                return new ConversationApi(Key, Secret, BaseUri);
            }
        }
    }
}
