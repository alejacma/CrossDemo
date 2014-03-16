using Microsoft.Phone.Controls;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WPApp
{
    public class Item
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Inicializamos la vista
            this.Message.Text = "Some default message";
            this.List.ItemsSource = new ObservableCollection<Item>() { 
                new Item() { Name = "Name 1", Description = "Description 1" }, 
                new Item() { Name = "Name 2", Description = "Description 2" } 
            };

        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Actualizamos la vista
            this.List.ItemsSource.Add(
                new Item()
                {
                    Name = "Name " + (this.List.ItemsSource.Count + 1),
                    Description = "Description " + (this.List.ItemsSource.Count + 1)
                }
            );
            this.Message.Text = "Some other message " + this.List.ItemsSource.Count;

        }

        private void Item_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Item item = (sender as StackPanel).DataContext as Item;
            MessageBox.Show("Item: " + item.Name + " - " + item.Description);
        }
    }
}