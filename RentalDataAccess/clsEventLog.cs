using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalDataAccess
{
    internal class clsEventLog
    {
        public static void SaveEventLog(string Message, EventLogEntryType LogType, string SourceName = "Rental Car")
        {
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
            }

            EventLog.WriteEntry(SourceName, Message, LogType);
        }
    }
}
