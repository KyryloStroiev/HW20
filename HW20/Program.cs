using HW20;
using System;
using System.Text.Json;

var bookMeeting = new BookMeeting();
bookMeeting.TextMeeting();
var serializer = new Serializer();
serializer.SerializeMeeting("Using.json");
serializer.Deserialize("Using.json");

