using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class VideoConverter
    {
        // We create a facade class to hide the framework's complexity
        // behind a simple interface. It's a trade-off between
        // functionality and simplicity.
        public VideoFile Convert(string filename, string format)
        {
            var file = new VideoFile(filename);
            Codec sourceCodec = CodecFactory.Extract(file);
            Codec destinationCodec;
            if (format == "mp4")
            {
                destinationCodec = new MPEG4CompressionCodec();
            }
            else
            {
                destinationCodec = new OggCompressionCodec();
            }

            var buffer = BitrateReader.Read(filename, sourceCodec);
            var result = BitrateReader.Convert(buffer, destinationCodec);
            result = (new AudioMixer()).Fix(result);
            return new VideoFile(result);
        }

    }
}
