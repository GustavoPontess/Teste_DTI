using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class ReminderGroup
    {
        public DateTime Date { get; set; }
        public List<Reminder> Reminders { get; set; }
    }
}