using System;
using System.Threading;

namespace EventsAndDelegates
{
    internal class VideoEncoder
    {
        // 1. Define a delegate
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2. Define an event based on the delegate
        // public event VideoEncodedEventHandler VideoEncoded;

        // Sustituye a las dos líneas anteriores
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            // 3. Raise the event
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs { Video = video });
        }
    }
}
