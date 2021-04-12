using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new YouTubeManager();

            Console.ReadLine();
            manager.ProcessVideoPage(1);


            Console.ReadLine();
            manager.ProcessVideoPage(1);
        }

    }
}
