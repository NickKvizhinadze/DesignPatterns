using System;

namespace Events.App.Services
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending an email ... Video \"{e.Video?.Title}\" has been encoded.");
        }
    }
}
