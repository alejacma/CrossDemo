using CrossPCL.Models;
using CrossPCL.Services;
using CrossPCL.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CrossPCL.ViewModels
{
    // Vista modelo de la vista principal
    public class MainViewModel: BindableBase
    {
        // Propiedades que se pueden utilizar en las vistas
        private string message;
        public string Message { get { return message; } set { SetProperty(ref message, value); } }

        private ObservableCollection<Item> list;
        public ObservableCollection<Item> List { get { return list; } set { SetProperty(ref list, value); } }

        // Métodos que se pueden llamar desde las vistas
        public ICommand AddItemCommand { get; set; }
        public ICommand ShowItemCommand { get; set; }

        // Servicios de los que depende el vista modelo
        private IMessagingService MessagingService { get; set; }

        // Constructor
        public MainViewModel(IMessagingService messagingService)
        {
            // Inicializa las propiedades
            this.Message = "Some default message";
            this.List = new ObservableCollection<Item>() { 
                new Item() { Name = "Name 1", Description = "Description 1" }, 
                new Item() { Name = "Name 2", Description = "Description 2" } 
            };

            // Inicializa los métodos
            this.AddItemCommand = new DelegateCommand(AddItem);
            this.ShowItemCommand = new DelegateCommand<Item>(ShowItem);

            // Inicializa los servicios
            this.MessagingService = messagingService;
        }

        // Implementación de los métodos
        private void AddItem()
        {
            this.List.Add(
                new Item() { 
                    Name = "Name " + (this.List.Count + 1), 
                    Description = "Description " + (this.List.Count + 1) 
                }
            );
            this.Message = "Some other message " + this.List.Count;
        }

        private void ShowItem(Item item)
        {
            this.MessagingService.ShowMessage("Item: " + item.Name + " - " + item.Description);
        }
    }
}
