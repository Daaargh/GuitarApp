using System;
using System.Windows.Input;

namespace GuitarApp.ViewModel.Commands
{
    public class NoteQueryCommand : ICommand
    {
        public GuitarViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }



        public NoteQueryCommand(GuitarViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return VM.ButtonEnabled;
        }

        public void Execute(object parameter)
        {
            //string note = parameter as string;
            VM.ButtonEnabled = false;
            VM.Setter = "dictionary";
            VM.GetLowENote();
            VM.GetANote();
            VM.GetDNote();
            VM.GetGNote();
            VM.GetBNote();
            VM.GetHighENote();
            VM.Setter = "toldy";
        }
    }
}
