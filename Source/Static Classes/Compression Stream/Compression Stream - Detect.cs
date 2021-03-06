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

namespace DaanV2.NBT {
    public static partial class CompressionStream {
        /// <summary>Detect which compression has been used</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Detect which compression has been used</returns>
        public static NBTCompression DetectCompression(Stream stream) {
            if (!stream.CanSeek) {
                throw new ArgumentException($"{nameof(stream)} must be able to seek");
            }

            Int32 Temp = (Byte)stream.ReadByte();
            stream.Seek(-1, SeekOrigin.Current);

            //Byte is a nbt tag type
            if (Temp >= 0 && Temp <= 12) {
                return NBTCompression.None;
            }

            //Magical numbers
            switch (Temp) {
                case 0x1F:
                    return NBTCompression.Gzip;

                case 0x78:
                    return NBTCompression.Zlib;

                case -1:
                    throw new EndOfStreamException();

                default:
                    throw new InvalidDataException("compression type is not recoginzed");
            }
        }
    }
}
