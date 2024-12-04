using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace WindowsFormsApp2
{
    public class HttpRestSendItem
    {
        public string Url { get; set; }

        public HttpMethod Method { get; set; }

        public Dictionary<string, string> Headers { get; set; }

        public Dictionary<string, string> FileNameAndPath { get; set; }
        public StringContent StringContent { get; set; }
        public bool HasFile { get => FileNameAndPath != null && FileNameAndPath.Any(); }

        public HttpRestSendItem(string url, HttpMethod method, Dictionary<string, string> headers, Dictionary<string, string> filePath)
        {
            Url = url;
            Method = method;
            Headers = headers;
            FileNameAndPath = filePath;
        }

    }
}
