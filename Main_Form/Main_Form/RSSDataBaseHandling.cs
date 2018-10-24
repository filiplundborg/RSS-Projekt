﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Main_Form
{
    public static class RSSDataBaseHandling
    {

        private const string FILEPATH = "podcastfeed.xml";

        public static string GetName(string path)
        {
            string url = path;
            var reader = XmlReader.Create(url);
            var feed = SyndicationFeed.Load(reader);

            return feed.Title.Text;
        }

        public static RssList<Avsnitt> GetAvsnitt(string path)
        {
            string url = path;
            var reader = XmlReader.Create(url);
            var feed = SyndicationFeed.Load(reader);
            RssList<Avsnitt> listan = new RssList<Avsnitt>();
            
            foreach (var items in feed.Items)
            {
                Avsnitt avsnitt = new Avsnitt();
                avsnitt.Namn = items.Title.Text;
                avsnitt.Beskrivning = items.Summary.Text.Replace("<p>", "").Replace("</p>", "");

                listan.Add(avsnitt);
            }

            return listan;
        }
        public static void Serialize(FeedList feedList) {
            var serializer = new XmlSerializer(typeof (FeedList));
            using (var writer = new StreamWriter(FILEPATH)) {
                serializer.Serialize(writer, feedList);
            }
        }

        public static FeedList Deserialize()
        {
            FeedList feedList = new FeedList();

            var serializer = new XmlSerializer(typeof(FeedList));
            using (var reader = new StreamReader(FILEPATH))
            {
                feedList = serializer.Deserialize(reader) as FeedList;
            }
            return feedList;
        }



    }
}
