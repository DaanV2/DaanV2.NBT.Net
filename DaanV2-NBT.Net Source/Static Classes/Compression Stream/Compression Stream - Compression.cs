/*ISC License

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
using ComponentAce.Compression.Libs.zlib;

namespace DaanV2.NBT {
    public static partial class CompressionStream {
        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        /// <param name="Compression"></param>
        ///DOLATER <returns>Fill return</returns>
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

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        /// <param name="Compression"></param>
        ///DOLATER <returns>Fill return</returns>
        public static Stream GetCompressionStream(String Filepath, NBTCompression Compression) {
            return GetCompressionStream(new FileStream(Filepath, FileMode.Open, FileAccess.Read), Compression);
        }
    }
}
