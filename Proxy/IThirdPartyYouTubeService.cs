using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    interface IThirdPartyYouTubeService
    {
        List<Video> ListVideos();
        Video GetVideoInfo(int id);
        void DownloadVideo(int id);
    }
}
