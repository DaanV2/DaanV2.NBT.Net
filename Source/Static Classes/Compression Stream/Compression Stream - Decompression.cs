﻿/*ISC License

Copyright (c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.IO;
using System.IO.Compression;

namespace DaanV2.NBT {
    public static partial class CompressionStream {
        /// <summary>Gets a decompression stream from the specified information</summary>
        /// <param name="stream">The stream to wrap around</param>
        /// <param name="Compression">The compression type to use</param>
        /// <returns>Gets a decompression stream from the specified information</returns>
        public static Stream GetDecompressionStream(Stream stream, NBTCompression Compression = NBTCompression.Auto) {
            if (Compression == NBTCompression.Auto) {
                Compression = DetectCompression(stream);
            }

            switch (Compression) {
                default:
                    return stream;

                case NBTCompression.Gzip:
                    return new GZipStream(stream, CompressionMode.Decompress);

                case NBTCompression.Zlib:
                    stream.Seek(2, SeekOrigin.Begin);
                    return new DeflateStream(stream, CompressionMode.Decompress, true);
            }
        }

        /// <summary>Gets a decompression stream from the specified information</summary>
        /// <param name="Filepath">File to create a stream from</param>
        /// <param name="Compression">The compression type to use</param>
        /// <returns>Gets a decompression stream from the specified information</returns>
        public static Stream GetDecompressionStream(String Filepath, NBTCompression Compression) {
            return GetDecompressionStream(new FileStream(Filepath, FileMode.Open, FileAccess.Read), Compression);
        }
    }
}
