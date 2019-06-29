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

namespace DaanV2.NBT {
    public static partial class NBTReader {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        public static ITag ReadFile(String Filepath, NBTCompression Compression = NBTCompression.Auto) {
            FileStream Reader = new FileStream(Filepath, FileMode.Open, FileAccess.ReadWrite);
            ITag Out = ReadFile(Reader, Compression);
            Reader.Close();

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        public static ITag ReadFile(Stream stream, NBTCompression Compression = NBTCompression.Auto) {
            stream = NBTReader.GetStream(stream, Compression);
            return Read(stream);
        }
    }
}