using System;

class ParseURL
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";

        int serverIndex = url.IndexOf("://");
        int resIndex = url.Substring(serverIndex + 3).IndexOf("/") + serverIndex + 3;

        Console.WriteLine("[protocol] = " + url.Substring(0, serverIndex));
        Console.WriteLine("[server] = " + url.Substring(serverIndex + 3, resIndex - serverIndex - 3));
        Console.WriteLine("[resource] = " + url.Substring(resIndex));
    }
}