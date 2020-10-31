using System;

namespace EventAppDesignChallenge.Models
{
    public class EventModel
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public string HeartIcon => "\uf004";
        public string MarkerIcon => "\uf041";
    }
}
