using System;

namespace EventsAndDelegates
{
    internal class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("{0}: Sending a text message for {1}...", nameof(MessageService), e.Video.Title);
        }
    }
}
