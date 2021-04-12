using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IThirdPartyYouTubeService videoService = new ThirdPartyYouTubeService();
            IThirdPartyYouTubeService cachedVideoService = new CachedYouTubeService(videoService);
            var manager = new YouTubeManager(cachedVideoService);

            Console.ReadLine();
            manager.ProcessVideoPage(1);


            Console.ReadLine();
            manager.ProcessVideoPage(1);
        }

    }
}
