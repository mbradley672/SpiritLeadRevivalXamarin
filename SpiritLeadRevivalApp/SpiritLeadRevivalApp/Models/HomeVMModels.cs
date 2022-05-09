using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpiritLeadRevivalApp.Utilities;

namespace SpiritLeadRevivalApp.Models {
    public class CarouselItem {
        public int id { get; set; }
        public string caption { get; set; }
        public string imageURL { get; set; }
    }

    public class DailyScripture {
        public int id { get; set; }
        public string verse { get; set; }
    }

    public class Event {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }

    public class VideoFile {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string videoUrl { get; set; }
    }

    public class HomeRoot {
        public IList<CarouselItem> carouselItems { get; set; }
        public DailyScripture dailyScripture { get; set; }
        public IList<Event> events { get; set; }
        public IList<VideoFile> videoFiles { get; set; }
    }

    
}