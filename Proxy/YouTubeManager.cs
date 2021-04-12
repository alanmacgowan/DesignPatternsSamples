using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class YouTubeManager 
    {

        IThirdPartyYouTubeService _videoService;

        public YouTubeManager(IThirdPartyYouTubeService videoService)
        {
            _videoService = videoService;
        }

        public Video RenderVideoPage(int id)
        {
            var video = _videoService.GetVideoInfo(id);
            return video;
        }

        public List<Video> RenderListPanel()
        {
            var list = _videoService.ListVideos();
            return list;
        }

        public void ProcessVideoPage(int id)
        {
            _videoService.DownloadVideo(id);
            var list = _videoService.ListVideos();
            var video = _videoService.GetVideoInfo(id);
        }
    }
}
