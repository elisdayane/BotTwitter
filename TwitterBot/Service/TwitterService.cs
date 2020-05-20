using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;
using TwitterBot.Model;

namespace TwitterBot.Service
{
    public class TwitterService : ITwitterService
    {

        private Context _context;

        public TwitterService(Context contexto)
        {
            _context = contexto;
        }

        public IList<TweetsInfo> SearchTag(string tag)
        {
            //testando
            Auth.SetUserCredentials("L8LRcRz3g506juGH0Zs4EiHVm", "HKyZcx98BsOdVJtLRnZD6pG9SACwklYcunMewp52Y0UJV2pnpI", "14617355-KFgcrQgMHTRheEZbeCmrqf5KX8yKBsg3sIFb0wbuf", "oGmsuSSOeTgBaysfBDFuZo3ZjTptqXMkRClzM8zFhnwch");

            var searchParameter = new SearchTweetsParameters(tag)
            {
                Lang = LanguageFilter.Portuguese,
                MaximumNumberOfResults = 100
            };

            var tweets = Search.SearchTweets(searchParameter);

            return null; //teste

        }

    }
}
