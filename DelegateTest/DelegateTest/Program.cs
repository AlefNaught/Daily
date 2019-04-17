using System;

namespace DelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var video = new Video() {Title = "Video 1"};
            var videoEncoder = new VideoEncoder();

            videoEncoder.Encode(video);
        }

        public void OnVideoEncoded(object source, EventArgs e)
        {
            
        }
    }
}