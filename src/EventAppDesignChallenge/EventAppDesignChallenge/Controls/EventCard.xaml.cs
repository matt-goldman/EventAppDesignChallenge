using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventAppDesignChallenge.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventCard : ContentView
    {
        public static readonly BindableProperty BackgroundImageProperty = BindableProperty.Create("BackgroundImage", typeof(string), typeof(EventCard), null);        
        public string BackgroundImage
        {
            get
            {
                return (string) GetValue(BackgroundImageProperty);
            }
            set
            {
                SetValue (BackgroundImageProperty, value);
            }
        }

        public static readonly BindableProperty EventNameProperty = BindableProperty.Create("EventName", typeof(string), typeof(EventCard), null);
        public string EventName
        {
            get
            {
                return (string)GetValue(EventNameProperty);
            }
            set
            {
                SetValue(EventNameProperty, value);
                Debug.WriteLine("Event Name: " + EventName);
            }
        }

        public static readonly BindableProperty AddressProperty = BindableProperty.Create("Address", typeof(string), typeof(EventCard), null);
        public string Address
        {
            get
            {
                return (string)GetValue(AddressProperty);
            }
            set
            {
                SetValue(AddressProperty, value);
            }
        }

        public static readonly BindableProperty LikeIconProperty = BindableProperty.Create("LikeIcon", typeof(string), typeof(EventCard), null);
        public string LikeIcon 
        { 
            get
            {
                return (string)GetValue(LikeIconProperty);
            }
            set
            {
                SetValue(LikeIconProperty, value);
            }
        }

        public static readonly BindableProperty MarkerIconProperty = BindableProperty.Create("MarkerIcon", typeof(string), typeof(EventCard), null);
        public string MarkerIcon 
        { 
            get
            {
                return (string)GetValue(MarkerIconProperty);
            }
            set
            {
                SetValue(MarkerIconProperty, value);
                Debug.WriteLine("Marker Icon:" + MarkerIcon);
            }
        }

        public static readonly BindableProperty EventDateProperty = BindableProperty.Create("EventDate", typeof(DateTime), typeof(EventCard), null);
        public DateTime EventDate 
        { 
            get
            {
                return (DateTime)GetValue(EventDateProperty);
            }
            set
            {
                SetValue(EventDateProperty, value);
                Debug.WriteLine("Event Date: " + EventDate);
            }
        }

        public string EventMonth => EventDate.ToString("MMM");
        public string EventDayOfMonth => EventDate.ToString("dd");

        public EventCard()
        {
            InitializeComponent();
        }
    }
}