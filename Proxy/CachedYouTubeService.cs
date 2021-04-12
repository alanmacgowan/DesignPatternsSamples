using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class CachedYouTubeService : IThirdPartyYouTubeService
    {
        IThirdPartyYouTubeService _videoService;
        public bool NeedReset => false;

        List<Video> CachedVideoList;

        Video CachedVideo;

        public CachedYouTubeService(IThirdPartyYouTubeService videoService)
        {
            _videoService = videoService;
        }

        public void DownloadVideo(int id)
        {
            _videoService.DownloadVideo(id);
        }

        public Video GetVideoInfo(int id)
        {
            if (CachedVideo == null || NeedReset)
                CachedVideo = _videoService.GetVideoInfo(id);

            return CachedVideo;
        }

        public List<Video> ListVideos()
        {
            if (CachedVideoList == null || NeedReset)
                CachedVideoList = _videoService.ListVideos();

            return CachedVideoList;
        }
    }
}
