using HW20;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HW20;

public class Serializer
{
    public static List<BookMeeting> SomebookMeetings;
    public  void SerializeMeeting(string path)
    {
        using var fileStream = new FileStream(path, FileMode.OpenOrCreate);
        JsonSerializer.Serialize(fileStream, SomebookMeetings);

    }
    public  void Deserialize (string path)
    {
        using var fileStream = new FileStream(path,
         FileMode.OpenOrCreate);
        var companies = JsonSerializer.Deserialize<List<BookMeeting>>(fileStream);
        foreach(var companie in companies)
        {
            Console.WriteLine($"{companie.DateMeeting.ToString()} , {companie.ThemeMeeting}");
        }
        

    }
   
   
}
