using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    public class FeedList : RssList<Feed>, ISaveAndLoadable<FeedList>
    {
        public delegate void ListChangedHandler();
        public event ListChangedHandler ListChanged;

        public delegate void InitializeUpdateHandler();
        public event InitializeUpdateHandler TimerElapsed;

        public void Save() {
            RSSDataBaseHandling.Serialize(this);
        }
        public FeedList Load() {
            return RSSDataBaseHandling.Deserialize();
        }

        public void RemoveAtIndex(int index) {
            this.RemoveAt(index);
            ListChanged();
        }
        public void AddTimerEvent() {
            foreach (var feed in this) {
                feed.FeedChanged += () =>
                {
                    UpdateForm();
                };
            } 
        }
        public void UpdateForm() {
            TimerElapsed();
        }

    
        public override RssList<Feed> SortList(object obj)
        {
            FeedList SortedFeedList = new FeedList();
            Category category = obj as Category;
            if (category != null) {

                
                var List = this.OrderByDescending((item) => item.TheCategory == category.TheCategory).ToList();
                foreach (var item in List)
                {
                    SortedFeedList.Add(item);
                }
                
            }
            return SortedFeedList;

        }
    } 

}
