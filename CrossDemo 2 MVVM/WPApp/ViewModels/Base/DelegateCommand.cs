using System;
using System.Windows.Input;

namespace CrossPCL.ViewModels.Base
{
    // Utilizada por la vista para hacer binding de comandos a métodos de los vista-modelo. Los comandos no admiten parámetros
    public class DelegateCommand : ICommand
    {
        // Comando a ejecutar
        private Action _execute;

        // Puede ejecutarse el comando?
        private Func<bool> _canExecute;

        // Constructor
        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        // Constructor
        public DelegateCommand(Action execute) : this(execute, null) 
        { 
        }

        // Dime si se puede ejecutar el comando
        public bool CanExecute(object parameter)
        {
            if (this._canExecute == null)
            {
                return true;
            }

            return this._canExecute();
        }

        // Evento al que me puedo subscribir para saber si el estado de ejecución del comando ha cambiado
        public event EventHandler CanExecuteChanged;

        // Notifica cualquier cambio en el estado de ejecución del comando
        public void RaiseCanExecuteChanged()
        {
            if (this.CanExecuteChanged != null)
            {
                this.CanExecuteChanged(this, EventArgs.Empty);
            }
        }

        // Ejecuta el comando sin parámetros
        public void Execute(object parameter)
        {
            if (this._execute != null)
            {
                this._execute();
            }
        }
    }

    // Utilizada por la vista para hacer binding de comandos a métodos de los vista-modelo. Los comandos admiten un parámetro
    public class DelegateCommand<T> : ICommand
    {
        // Comando a ejecutar
        private Action<T> _execute;

        // Puede ejecutarse el comando?
        private Func<Boolean> _canExecute;

        // Constructor
        public DelegateCommand(Action<T> execute, Func<Boolean> canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        // Constructor
        public DelegateCommand(Action<T> execute)
            : this(execute, null)
        {
        }
        
        // Dime si se puede ejecutar el comando
        public bool CanExecute(object parameter)
        {
            if (this._canExecute == null)
            {
                return true;
            }

            return this._canExecute();
        }

        // Evento al que me puedo subscribir para saber si el estado de ejecución del comando ha cambiado
        public event EventHandler CanExecuteChanged;

        // Notifica cualquier cambio en el estado de ejecución del comando
        public void RaiseCanExecuteChanged()
        {
            if (this.CanExecuteChanged != null)
            {
                this.CanExecuteChanged(this, EventArgs.Empty);
            }
        }

        // Ejecuta el comando sin parámetros
        public void Execute(object parameter)
        {
            if (this._execute != null)
            {
                this._execute((T)parameter);
            }
        }
    }
}