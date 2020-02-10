using Caliburn.Micro;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Spis.ViewModels
{
    public class ListStatusViewModel : Conductor<object>.Collection.OneActive, IShell
    {
        private ObservableCollection<ListContainerViewModel> _listContainers;

        public ObservableCollection<ListContainerViewModel> listContainers
        {
            get => _listContainers; set
            {
                _listContainers = value;
                NotifyOfPropertyChange(() => listContainers);
            }
        }

        public ListStatusViewModel()
        {
            listContainers = new ObservableCollection<ListContainerViewModel>();
            listContainers.Add(new ListContainerViewModel(){Description = "TextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextTextText" });
            listContainers.Add(new ListContainerViewModel() { Description = "Text" });
            listContainers.Add(new ListContainerViewModel() { Description = "Text" });
            listContainers.Add(new ListContainerViewModel() { Description = "Text" });
        }
    }
}
