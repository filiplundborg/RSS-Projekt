using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
