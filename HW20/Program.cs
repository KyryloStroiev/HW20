using HW20;
using System;
using System.Text.Json;

var bookMeeting = new BookMeeting();
bookMeeting.TextMeeting();

using var fileStream = new FileStream("User.json", FileMode.OpenOrCreate);
{
    var meeting = bookMeeting;
    JsonSerializer.Serialize<BookMeeting>(fileStream, meeting);

}
using var fileStream1 = new FileStream("User.json", FileMode.OpenOrCreate);
{
    var meetings = JsonSerializer.Deserialize<BookMeeting>(fileStream1);
    Console.WriteLine($"{meetings.DateMeeting} {meetings.ThemeMeeting}");
}