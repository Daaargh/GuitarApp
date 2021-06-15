using System;
using System.Windows.Input;

namespace GuitarApp.ViewModel.Commands
{
    public class ClearTextboxesCommand : ICommand
    {
        public GuitarViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }



        public ClearTextboxesCommand(GuitarViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.Setter = "dictionary";
            VM.ClearTextBoxes();
            VM.ButtonEnabled = true;
            VM.Setter = "toldy";
        }
    }
}
