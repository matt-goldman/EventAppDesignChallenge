using EventAppDesignChallenge.ViewModels;
using Xamarin.Forms;


namespace EventAppDesignChallenge.Pages
{
    public partial class EventListPage : ContentPage
    {
        public EventListViewModel ViewModel { get; set; }
        public EventListPage()
        {
            ViewModel = new EventListViewModel();
            ViewModel.Navigation = Navigation;
            BindingContext = ViewModel;
            InitializeComponent();
        }
    }
}