using System;

namespace Facade
{
    class Program
    {
        // Application classes don't depend on a billion classes
        // provided by the complex framework. Also, if you decide to
        // switch frameworks, you only need to rewrite the facade class.
        static void Main(string[] args)
        {
            var convertor = new VideoConverter();
            var mp4 = convertor.Convert("funny-cats-video.ogg", "mp4");
            mp4.Save();
        }
    }
}
