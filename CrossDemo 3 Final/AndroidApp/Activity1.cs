using Android.App;
using Android.OS;
using Android.Widget;
using AndroidApp.Services;
using CrossPCL.ViewModels;
using System;

namespace AndroidApp
{
    [Activity(Label = "AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        private Button button;
        private ListView list;
        private TextView message;

        private MainViewModel viewModel;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Procesa la vista
            SetContentView(Resource.Layout.Main);
            this.message = FindViewById<TextView>(Resource.Id.MyMessage);
            this.list = FindViewById<ListView>(Resource.Id.MyList);
            this.list.ItemClick += new EventHandler<AdapterView.ItemClickEventArgs>(Item_Click);
            this.button = FindViewById<Button>(Resource.Id.MyButton);
            this.button.Click += new EventHandler(Button_Click);

            // Asocia el vista modelo a la vista
            this.viewModel = new MainViewModel(new MessagingService(this));

            // Muestra los datos del vista modelo en la vista
            this.message.Text = this.viewModel.Message;
            this.list.Adapter = new ItemsAdapter(this, this.viewModel.List);
        }

        public void Button_Click(object sender, EventArgs e)
        {
            // Ejecuta el método del vista modelo
            this.viewModel.AddItemCommand.Execute(null);

            // Actualiza la vista
            this.message.Text = this.viewModel.Message;
            this.list.InvalidateViews();
        }

        public void Item_Click(object sender, AdapterView.ItemClickEventArgs e)
        {
            // Ejecuta el método del vista modelo
            this.viewModel.ShowItemCommand.Execute(this.viewModel.List[(int)e.Id]);
        }
    }
}

