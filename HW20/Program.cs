using HW20;
using System;
using System.Text.Json;

var bookMeeting = new BookMeeting();

var serializer = new Serializer();
 
    Console.WriteLine("Для запису нової зустрiчi натиснiть \"R\" Для перегляду записiв натисніть \"W\" ");
    var entercod = Convert.ToChar(Console.ReadLine());
    if(entercod == 'R')
    {
    bookMeeting.TextMeeting();
    serializer.SerializeMeeting("Using.json");
    }
    else if (entercod == 'W')
    {
        

        serializer.Deserialize("Using.json");
    }
    else
    {
        Console.WriteLine("Ви вели неправильний символ");
        
    }
 



