
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace SIoIMwElblaguMobileAndorid.Models
{
   

    public partial class Event
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("place")]
        public string Place { get; set; }

        [JsonProperty("dateStart")]
        public string DateStart { get; set; }

        [JsonProperty("dataEnd")]
        public string DataEnd { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
