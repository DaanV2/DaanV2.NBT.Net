using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT {
    public static partial class CompressionStream {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="Compression"></param>
        /// <returns></returns>
        public static Stream GetDecompressionStream(Stream stream, NBTCompression Compression = NBTCompression.Auto) {
            if (Compression == NBTCompression.Auto)
                Compression = DetectCompression(stream);

            switch (Compression) {
                default:
                    return stream;

                case NBTCompression.Gzip:
                    return new Compression.GzipStream(stream, CompressionMode.Decompress);

                case NBTCompression.Zlib:
                    return new Compression.ZlibStream(stream);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="Compression"></param>
        /// <returns></returns>
        public static Stream GetDecompressionStream(String Filepath, NBTCompression Compression) {
            return GetDecompressionStream(new FileStream(Filepath, FileMode.Open, FileAccess.Read), Compression);
        }
    }
}
