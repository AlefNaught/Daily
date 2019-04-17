using System;
using System.Threading;

namespace DelegateTest
{
    public class VideoEncoder
    {
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding...");
            Thread.Sleep(3000);
        }
    }
}