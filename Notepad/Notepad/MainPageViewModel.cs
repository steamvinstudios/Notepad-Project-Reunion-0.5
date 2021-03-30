using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Notepad
{
    class MainPageViewModel : ViewModelBase
    {
        public ICommand ChangeTextCommand { get; set; }
        private string appTitle;
        public string AppTitle { get => appTitle; set => SetProperty(ref appTitle, value); }
        public MainPageViewModel()
        {
            AppTitle = "Notepad";
            ChangeTextCommand = new AppCommand(ChangeText);
        }
        private void ChangeText()
        {
            AppTitle = "New Title";
        }
    }
}
