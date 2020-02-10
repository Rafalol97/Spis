using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Spis.ViewModels
{
    public class ShellViewModel : Conductor<object>.Collection.OneActive, IShell
    {
        private ListStatusViewModel _ListStatusViewModel{ get; set; }

        private IWindowManager _windowManager;
        public ShellViewModel(IWindowManager WindowManager)
        {
            _windowManager = WindowManager;
            _ListStatusViewModel = new ListStatusViewModel();
            ActivateItem(_ListStatusViewModel);
        }
    }
}
