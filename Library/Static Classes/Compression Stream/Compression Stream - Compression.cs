/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;
using System.IO.Compression;
using ComponentAce.Compression.Libs.zlib;

namespace DaanV2.NBT; 
public static partial class CompressionStream {
    /// <summary>Checks the given compression tag and creates a compression stream around the given stream</summary>
    /// <param name="stream">The stream to wrap around</param>
    /// <param name="Compression">The compression type to use</param>
    /// <returns>Checks the given compression tag and creates a compression stream around the given stream</returns>
    public static Stream GetCompressionStream(Stream stream, NBTCompression Compression = NBTCompression.Auto) {
        switch (Compression) {
            case NBTCompression.None:
            default:
                return stream;

            case NBTCompression.Gzip:
                return new GZipStream(stream, CompressionLevel.Optimal);

            case NBTCompression.Zlib:
                return new ZOutputStream(stream, zlibConst.Z_BEST_COMPRESSION);
        }
    }

    /// <summary>Creates a new stream that supports possible compression</summary>
    /// <param name="Filepath">The file to create a stream from</param>
    /// <param name="Compression">The compression type to use</param>
    /// <returns>Creates a new stream that supports possible compression</returns>
    public static Stream GetCompressionStream(String Filepath, NBTCompression Compression) {
        return GetCompressionStream(new FileStream(Filepath, FileMode.Open, FileAccess.Read), Compression);
    }
}
