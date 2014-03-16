using CrossPCL.ViewModels;
using W8App.Services;
using Windows.UI.Xaml.Controls;

namespace W8App
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Asocio la vista con su vista modelo
            this.DataContext = new MainViewModel(new MessagingService());
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Llamo a un método del vista modelo
            (this.DataContext as MainViewModel).ShowItemCommand.Execute(e.ClickedItem);
        }
    }
}
