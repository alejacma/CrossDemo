using CrossPCL.ViewModels.Base;

namespace CrossPCL.Models
{
    public class Item: BindableBase
    {
        private string name;
        public string Name { get { return name; } set { SetProperty(ref name, value); } }

        private string description;
        public string Description { get { return description; } set { SetProperty(ref description, value); } }
    }
}
