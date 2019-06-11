using System;

namespace Events.App.Services
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MessageService: Sendind a text message ...Video \"{e.Video?.Title}\" has been encoded.");
        }
    }
}
