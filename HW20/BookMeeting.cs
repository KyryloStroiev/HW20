using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW20;

public class BookMeeting
{
    public DateOnly DateMeeting { get; set; }
    public string ThemeMeeting { get; set; }
    public BookMeeting(DateOnly datemeeting, string thememeeting)
    {

        DateMeeting = datemeeting;
        ThemeMeeting = thememeeting;
    }

    public BookMeeting()
    {
    }

    public List<(DateOnly DateMeeting, string ThemeMeeting)> TextMeeting()
    {
        var texts = new List<(DateOnly DateMeeting, string ThemeMeeting)>();
        Console.WriteLine("Щоби закiнчити запис натиснiть Enter");
        Console.WriteLine("Запишiть теми  зустрiчi");
        Console.WriteLine("Дата:");
        string datetime = Console.ReadLine();
        DateMeeting = DateOnly.Parse(datetime);
        Console.WriteLine("Тема:");
        ThemeMeeting = Console.ReadLine();
        return texts;




    }


}
