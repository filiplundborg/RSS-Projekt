using System;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Main_Form
{
    public static class RSSDataBaseHandling
    {

        private const string FILEPATH = "podcastfeed.xml";

        public static string GetName(string Path)
        {
            try
            {
                
                var Reader = XmlReader.Create(Path);
                var Feed = SyndicationFeed.Load(Reader);

                return Feed.Title.Text;

            }
            catch (Exception)
            {
                
                return null;

            }
        }

        public static RssList<Episode> GetEpisodes(string Path)
        {
            try
            {
                
                var Reader = XmlReader.Create(Path);
                var Feed = SyndicationFeed.Load(Reader);
                RssList<Episode> TheList = new RssList<Episode>();

                foreach (var items in Feed.Items)
                {
                    Episode Episode = new Episode();
                    Episode.Name = items.Title.Text;
                    Episode.Description = items.Summary.Text.Replace("<p>", "").Replace("</p>", "");

                    TheList.Add(Episode);
                }

                return TheList;
            }
            catch(Exception)
            {
                
                return null;
                
            }
        }


        public static void Serialize(FeedList feedList) {
            var Serializer = new XmlSerializer(typeof (FeedList));
            using (var Writer = new StreamWriter(FILEPATH)) {
                Serializer.Serialize(Writer, feedList);
            }
        }

        public static FeedList Deserialize()
        {
            FeedList feedList = new FeedList();
            if (File.Exists(FILEPATH))
            {
                var serializer = new XmlSerializer(typeof(FeedList));
                using (var reader = new StreamReader(FILEPATH))
                {
                    feedList = serializer.Deserialize(reader) as FeedList;
                }
            }
            return feedList;
        }



    }
}
