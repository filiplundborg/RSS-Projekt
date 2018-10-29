using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form
{
    public class FeedList : RssList<Feed>, ISaveAndLoadable<FeedList>
    {
        public delegate void ListChanged();
        public event ListChanged changed;
        public delegate void InitialiseraUppdatering();
        public event InitialiseraUppdatering uppdatera;

        public void Save() {
            RSSDataBaseHandling.Serialize(this);
        }
        public FeedList Load() {
            return RSSDataBaseHandling.Deserialize();
        }

        public void RemoveAtIndex(int index) {
            this.RemoveAt(index);
            changed();
        }
        public void LaggTillEvent() {
            foreach (var v in this) {
                v.andrad += () =>
                {
                    UppdatForm();
                };
            } 
        }
        public void UppdatForm() {
            uppdatera();
        }

    
        public override RssList<Feed> SortList(object obj)
        {
            FeedList SortedFeedList = new FeedList();
            Kategori categori = obj as Kategori;
            if (categori != null) {

                
                var List = this.OrderByDescending((item) => item.Category == categori.Category).ToList();
                foreach (var item in List)
                {
                    SortedFeedList.Add(item);
                }
                
            }
            return SortedFeedList;

        }
    } 

}
