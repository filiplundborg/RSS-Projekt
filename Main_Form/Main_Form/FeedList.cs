using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    public class FeedList : RssList<Feed>
    {
        public void Save() {
            RSSDataBaseHandling.Serialize(this);
        }
        public FeedList Load() {
            return RSSDataBaseHandling.Deserialize();
        }
    }
}
