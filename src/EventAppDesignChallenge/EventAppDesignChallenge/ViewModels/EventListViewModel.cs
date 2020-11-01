using EventAppDesignChallenge.Models;
using System;
using System.Collections.ObjectModel;

namespace EventAppDesignChallenge.ViewModels
{
    public class EventListViewModel : BaseViewModel
    {
        public ObservableCollection<EventModel> Events { get; set; } = new ObservableCollection<EventModel>();
        public ObservableCollection<EventCategory> Categories { get; set; } = new ObservableCollection<EventCategory>();

        public DateTime Today => DateTime.Now;

        public string UserName => "Alina";

        public int EventCount => 235;
        public string SearchIcon => "\uf002";
        public string MicIcon => "\uf130";
        public string SliderIcon => "\uf1de";

        public EventListViewModel()
        {
            Events.Add(new EventModel
            {
                Address = "72 S Linden Ave, San Francisco",
                Date = new DateTime(2020, 10, 20),
                Image = "fashion1",
                Title = "Fashion Fair 2020"
            });
            Events.Add(new EventModel
            {
                Address = "1 Epping Road, North Ryde",
                Date = new DateTime(2020, 11, 21),
                Image = "fashion2",
                Title = "MonkeyFest USA"
            });

            Categories.Add(new EventCategory
            {
                Name = "All",
                Selected = false
            });
            Categories.Add(new EventCategory
            {
                Name = "Business",
                Selected = false
            });
            Categories.Add(new EventCategory
            {
                Name = "Fashion",
                Selected = true
            });
            Categories.Add(new EventCategory
            {
                Name = "Music",
                Selected = false
            });
            Categories.Add(new EventCategory
            {
                Name = "Art & Culture",
                Selected = false
            });
            Categories.Add(new EventCategory
            {
                Name = "Science & Technology",
                Selected = false
            });
            Categories.Add(new EventCategory
            {
                Name = "Sports",
                Selected = false
            });
            Categories.Add(new EventCategory
            {
                Name = "Food & Drink",
                Selected = false
            });
        }
    }
}