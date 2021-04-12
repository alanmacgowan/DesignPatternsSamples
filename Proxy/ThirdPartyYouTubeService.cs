using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class ThirdPartyYouTubeService : IThirdPartyYouTubeService
    {
        public void DownloadVideo(int id)
        {
            Console.WriteLine("Downloading Video from YouTube");
        }

        public Video GetVideoInfo(int id)
        {
            Console.WriteLine("Getting Video Info from YouTube.");
            return new Video();
        }

        public List<Video> ListVideos()
        {
            Console.WriteLine("Getting Video List from YouTube");
            return new List<Video>();
        }
    }
}
