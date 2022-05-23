using System;

namespace EventsAndDelegates
{
    internal class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("{0}: Sending an email for {1}...", nameof(MailService), e.Video.Title);
        }
    }
}
