using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterBot.Model;

namespace TwitterBot.Service
{
    public interface ITwitterService
    {
        IList<TweetsInfo> SearchTag(string tag);

    }
}
