using CrossPCL.ViewModels;
using Microsoft.Phone.Controls;
using WPApp.Services;

namespace WPApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Asocio la vista con su vista modelo
            this.DataContext = new MainViewModel(new MessagingService());
        }
    }
}