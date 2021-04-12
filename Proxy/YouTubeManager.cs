using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class YouTubeManager 
    {

        IThirdPartyYouTubeService _videoService;
        IThirdPartyYouTubeService _cachedVideoService;

        public YouTubeManager()
        {
            _videoService = new ThirdPartyYouTubeService();
            _cachedVideoService = new CachedYouTubeService(_videoService);
        }

        public Video RenderVideoPage(int id)
        {
            var video = _cachedVideoService.GetVideoInfo(id);
            return video;
        }

        public List<Video> RenderListPanel()
        {
            var list = _cachedVideoService.ListVideos();
            return list;
        }

        public void ProcessVideoPage(int id)
        {
            _videoService.DownloadVideo(id);
            var list = _cachedVideoService.ListVideos();
            var video = _cachedVideoService.GetVideoInfo(id);
        }
    }
}
