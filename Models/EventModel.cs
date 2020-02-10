using System;
using System.Collections.Generic;
using System.Text;

namespace Spis.Models
{
    public class EventModel
    {
        public int id { get; set; }
        public string Description { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int severity { get; set; }

    }
}
