using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Notepad
{
    class MainPageViewModel : ViewModelBase
    {
        private string appTitle;
        public string AppTitle { get => appTitle; set => SetProperty(ref appTitle, value); }
        public MainPageViewModel()
        {
            AppTitle = "Notepad";
        }
    }
}
