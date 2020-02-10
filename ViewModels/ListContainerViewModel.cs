
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Caliburn.Micro;

namespace Spis.ViewModels
{
    public class ListContainerViewModel : Conductor<object>.Collection.OneActive, IShell
    {
        public string Description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endTime { get; set; }
        public Status status { set; get; }
        public enum Status { PastDueDate, DueDate, BeforeDueDate, StartDate }
        public int orderNumber { get; set; }
        public string daysLeft  { get; set; }
    }
}
