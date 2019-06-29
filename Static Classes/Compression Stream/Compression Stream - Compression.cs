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
        public static Stream GetCompressionStream(Stream stream, NBTCompression Compression = NBTCompression.Auto) {

            switch (Compression) {
                case NBTCompression.None:
                default:
                    return stream;

                case NBTCompression.Gzip:
                    return new Compression.GzipStream(stream, CompressionMode.Compress);

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
        public static Stream GetCompressionStream(String Filepath, NBTCompression Compression) {
            return GetCompressionStream(new FileStream(Filepath, FileMode.Open, FileAccess.Read), Compression);
        }
    }
}
