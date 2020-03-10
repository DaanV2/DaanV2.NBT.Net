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
using DaanV2.Binary;

namespace DaanV2.NBT {
    public static partial class StreamExtension {
        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        /// <param name="Length"></param>
        ///DOLATER <returns>Fill return</returns>
        public static Byte[] ReadBytes(this Stream stream, Int32 Length) {
            Byte[] Buffer = new Byte[Length];
            stream.Read(Buffer, 0, Length);

            return Buffer;
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        ///DOLATER <returns>Fill return</returns>
        public static Int16 ReadInt16(this Stream stream, Endianness endianness) {
            Byte[] Data = new Byte[sizeof(Int16)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.Endian.ToInt16(Data, endianness);
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        ///DOLATER <returns>Fill return</returns>
        public static Int32 ReadInt32(this Stream stream, Endianness endianness) {
            Byte[] Data = new Byte[sizeof(Int32)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.Endian.ToInt16(Data, endianness);
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        ///DOLATER <returns>Fill return</returns>
        public static Int64 ReadInt64(this Stream stream, Endianness endianness) {
            Byte[] Data = new Byte[sizeof(Int64)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.Endian.ToInt64(Data, endianness);
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        ///DOLATER <returns>Fill return</returns>
        public static UInt16 ReadUInt16(this Stream stream, Endianness endianness) {
            Byte[] Data = new Byte[sizeof(UInt16)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.Endian.ToUInt16(Data, endianness);
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        ///DOLATER <returns>Fill return</returns>
        public static UInt32 ReadUInt32(this Stream stream, Endianness endianness) {
            Byte[] Data = new Byte[sizeof(UInt32)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.Endian.ToUInt32(Data, endianness);
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        ///DOLATER <returns>Fill return</returns>
        public static UInt64 ReadUInt64(this Stream stream, Endianness endianness) {
            Byte[] Data = new Byte[sizeof(UInt64)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.Endian.ToUInt64(Data, endianness);
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        ///DOLATER <returns>Fill return</returns>
        public static Single ReadFloat(this Stream stream, Endianness endianness) {
            Byte[] Data = new Byte[sizeof(Single)];
            stream.Read(Data, 0, Data.Length);

            return (Single)Binary.BitConverter.Endian.ToInt32(Data, endianness);
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        ///DOLATER <returns>Fill return</returns>
        public static Double ReadDouble(this Stream stream, Endianness endianness) {
            Byte[] Data = new Byte[sizeof(Double)];
            stream.Read(Data, 0, Data.Length);

            return (Double)Binary.BitConverter.Endian.ToInt64(Data, endianness);
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        /// <param name="Length"></param>
        ///DOLATER <returns>Fill return</returns>
        public static Int32[] ReadInt32Array(this Stream stream, Int32 Length, Endianness endianness) {
            Byte[] Buffer = new Byte[Length * sizeof(Int32)];
            Int32[] Out = new Int32[Length];
            stream.Read(Buffer, 0, Buffer.Length);
            Int32 J = 0;

            if (endianness == Endianness.BigEndian) {
                for (Int32 I = 0; I < Length; I++) {
                    Out[I] = Binary.BitConverter.BigEndian.ToInt32(Buffer, J);
                    J += 4;
                }
            }
            else {
                for (Int32 I = 0; I < Length; I++) {
                    Out[I] = Binary.BitConverter.LittleEndian.ToInt32(Buffer, J);
                    J += 4;
                }
            }

            return Out;
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <param name="stream">FILL IN</param>
        /// <param name="Length"></param>
        ///DOLATER <returns>Fill return</returns>
        public static Int64[] ReadInt64Array(this Stream stream, Int32 Length, Endianness endianness) {
            Byte[] Buffer = new Byte[Length * sizeof(Int64)];
            Int64[] Out = new Int64[Length];
            stream.Read(Buffer, 0, Buffer.Length);
            Int32 J = 0;

            if (endianness == Endianness.BigEndian) {
                for (Int32 I = 0; I < Length; I++) {
                    Out[I] = Binary.BitConverter.BigEndian.ToInt32(Buffer, J);
                    J += 4;
                }
            }
            else {
                for (Int32 I = 0; I < Length; I++) {
                    Out[I] = Binary.BitConverter.LittleEndian.ToInt32(Buffer, J);
                    J += 4;
                }
            }

            return Out;
        }
    }
}