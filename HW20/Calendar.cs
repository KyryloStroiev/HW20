using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW20;

public class Calendar
{
    public DateTime Datenow { get; set; }
    public List<BookMeeting> BookMeetings;
    public Calendar(DateTime datenow, List<BookMeeting> bookMeetings)
    {
        Datenow = datenow;
        BookMeetings = bookMeetings;
    }
    public Calendar() { }
    public void Calendardate()
    {
        Datenow = DateTime.Now;
        Console.WriteLine(Datenow.ToString());

    }
}
