using CrossPCL.Services;
using System.Windows;

namespace WPApp.Services
{
    public class MessagingService: IMessagingService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
