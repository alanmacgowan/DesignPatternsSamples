using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    // These are some of the classes of a complex 3rd-party video
    // conversion framework. We don't control that code, therefore
    // can't simplify it.

    public class VideoFile
    {
        private object result;

        public VideoFile(object result)
        {
            this.result = result;
        }

        internal void Save()
        {
            Console.WriteLine("Called Save");
        }
    }

    public interface Codec
    { }
    public class OggCompressionCodec : Codec
    { }

    public class MPEG4CompressionCodec : Codec
    { }

    public static class CodecFactory
    {

        public static Codec Extract(VideoFile file)
        {
            return new MPEG4CompressionCodec();
        }
    }

    public class BitrateReader
    {
        internal static object Read(string filename, Codec sourceCodec)
        {
            Console.WriteLine("Called Read");
            return null;
        }

        internal static object Convert(object buffer, Codec destinationCodec)
        {
            Console.WriteLine("Called Convert");
            return null;
        }
    }

    public class AudioMixer
    {
        internal object Fix(object result)
        {
            Console.WriteLine("Called Fix");
            return null;
        }
    }

}
