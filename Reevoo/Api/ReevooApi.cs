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

        /// <summary>
        /// Contains methods for retrieving organisation data.
        /// </summary>
        public OrganisationApi Organisation
        {
            get
            {
                return new OrganisationApi(Key, Secret, BaseUri);
            }
        }

        /// <summary>
        /// Contains methods for retrieving reviewable data.
        /// </summary>
        public ReviewableApi Reviewable
        {
            get
            {
                return new ReviewableApi(Key, Secret, BaseUri);
            }
        }

        /// <summary>
        /// Contains methods for retrieving review data.
        /// </summary>
        public ReviewApi Review
        {
            get
            {
                return new ReviewApi(Key, Secret, BaseUri);
            }
        }

        /// <summary>
        /// Contains methods for retrieving customer experience review data.
        /// </summary>
        public CustomerExperienceReviewApi CustomerExperienceReview
        {
            get
            {
                return new CustomerExperienceReviewApi(Key, Secret, BaseUri);
            }
        }

        /// <summary>
        /// Contains methods for retrieving conversation data.
        /// </summary>
        public ConversationApi Conversation
        {
            get
            {
                return new ConversationApi(Key, Secret, BaseUri);
            }
        }
    }
}
