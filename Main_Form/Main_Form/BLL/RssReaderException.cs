using System;


namespace Main_Form
{
    public class RssReaderException : Exception
    {
        public string UserMessage { get; set; }

        public RssReaderException() {}

        public RssReaderException(string userMessage) {
            this.UserMessage = userMessage;
        }

    }
}
