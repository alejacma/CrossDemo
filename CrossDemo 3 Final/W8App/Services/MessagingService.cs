using CrossPCL.Services;
using Windows.UI.Popups;

namespace W8App.Services
{
    public class MessagingService: IMessagingService
    {
        public void ShowMessage(string message)
        {
            MessageDialog dialog = new MessageDialog(message);
            dialog.ShowAsync();
        }
    }
}
