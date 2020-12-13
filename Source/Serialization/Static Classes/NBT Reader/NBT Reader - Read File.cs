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
using System.Runtime.CompilerServices;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    public static partial class NBTReader {
        /// <summary>Reads the content of the given file</summary>
        /// <param name="Filepath">The file to read from</param>
        /// <param name="endianness">The endianness of the nbt structure</param>
        /// <param name="Compression">The compression type used</param>
        /// <returns>Reads the content of the given file</returns>
        public static ITag ReadFile(String Filepath, Endianness endianness, NBTCompression Compression = NBTCompression.Auto) {
            Stream Stream = CompressionStream.GetDecompressionStream(new FileStream(Filepath, FileMode.Open, FileAccess.ReadWrite), Compression);
            ITag Out = ReadFile(new SerializationContext(endianness, Stream));
            Stream.Close();

            return Out;
        }

        /// <summary>Reads the content of the given file</summary>
        /// <param name="stream">The stream to read from</param>
        /// <param name="endianness">The endianness of the nbt structure</param>
        /// <returns>Reads the content of the given file</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ITag ReadFile(Stream stream, Endianness endianness) {
            return Read(stream, endianness);
        }

        /// <summary>Reads the content of the given file</summary>
        /// <param name="Context">The context to read from</param>
        /// <returns>Reads the content of the given file</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ITag ReadFile(SerializationContext Context) {
            return Read(Context);
        }
    }
}