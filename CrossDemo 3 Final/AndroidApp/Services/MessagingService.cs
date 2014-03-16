using Android.App;
using Android.Content;
using CrossPCL.Services;

namespace AndroidApp.Services
{
    public class MessagingService: IMessagingService
    {
        private Context context;

        public MessagingService(Context context)
        {
            this.context = context;
        }

        public void ShowMessage(string message)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(this.context);
            alert.SetMessage(message);
            alert.SetPositiveButton("OK", (IDialogInterfaceOnClickListener)null);
            alert.Show();
        }
    }
}
