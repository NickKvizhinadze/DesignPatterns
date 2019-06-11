using Events.App.Services;

namespace Events.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //Publisher
            var mailService = new MailService(); //Subscriber
            var messageService = new MessageService(); //Seccond Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //Register event handler
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; //Register Seccond event handler

            videoEncoder.Encode(video);
        }

        
    }
}
