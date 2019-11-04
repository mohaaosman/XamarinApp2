using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApp2.Models
{
    class Article
    {
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public long? UserId { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }
    }
    public class Source
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
