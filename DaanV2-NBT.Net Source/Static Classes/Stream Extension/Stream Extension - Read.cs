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
    public static partial class StreamExtension {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <param name="Length"></param>
        /// <returns></returns>
        public static Byte[] ReadBytes(this Stream stream, Int32 Length) {
            Byte[] Buffer = new Byte[Length];
            stream.Read(Buffer, 0, Length);

            return Buffer;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Int16 ReadInt16(this Stream stream) {
            Byte[] Buffer = new Byte[2];
            stream.Read(Buffer, 0, 2);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            return BitConverter.ToInt16(Buffer, 0);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Int32 ReadInt32(this Stream stream) {
            Byte[] Buffer = new Byte[4];
            stream.Read(Buffer, 0, 4);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            return BitConverter.ToInt32(Buffer, 0);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Int64 ReadInt64(this Stream stream) {
            Byte[] Buffer = new Byte[8];
            stream.Read(Buffer, 0, 8);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            return BitConverter.ToInt64(Buffer, 0);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static UInt16 ReadUInt16(this Stream stream) {
            Byte[] Buffer = new Byte[2];
            stream.Read(Buffer, 0, 2);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            return BitConverter.ToUInt16(Buffer, 0);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static UInt32 ReadUInt32(this Stream stream) {
            Byte[] Buffer = new Byte[4];
            stream.Read(Buffer, 0, 4);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            return BitConverter.ToUInt32(Buffer, 0);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static UInt64 ReadUInt64(this Stream stream) {
            Byte[] Buffer = new Byte[8];
            stream.Read(Buffer, 0, 8);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            return BitConverter.ToUInt64(Buffer, 0);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Single ReadFloat(this Stream stream) {
            Byte[] Buffer = new Byte[4];
            stream.Read(Buffer, 0, 4);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            return BitConverter.ToSingle(Buffer, 0);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Double ReadDouble(this Stream stream) {
            Byte[] Buffer = new Byte[8];
            stream.Read(Buffer, 0, 8);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            return BitConverter.ToDouble(Buffer, 0);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <param name="Length"></param>
        /// <returns></returns>
        public static Byte[] ReadByteArray(this Stream stream, Int32 Length) {
            Byte[] Buffer = new Byte[Length];
            stream.Read(Buffer, 0, Buffer.Length);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            return Buffer;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <param name="Length"></param>
        /// <returns></returns>
        public static Int32[] ReadInt32Array(this Stream stream, Int32 Length) {
            Byte[] Buffer = new Byte[Length * 4];
            Int32[] Out = new Int32[Length];

            stream.Read(Buffer, 0, Buffer.Length);
            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            Int32 J = 0;

            for (Int32 I = 0; I < Length; I++) {
                Out[I] = BitConverter.ToInt32(Buffer, J);
                J += 4;
            }

            return Out;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <param name="Length"></param>
        /// <returns></returns>
        public static Int64[] ReadInt64Array(this Stream stream, Int32 Length) {
            Byte[] Buffer = new Byte[Length * 8];
            Int64[] Out = new Int64[Length];

            stream.Read(Buffer, 0, Buffer.Length);
            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            Int32 J = 0;

            for (Int32 I = 0; I < Length; I++) {
                Out[I] = BitConverter.ToInt64(Buffer, J);
                J += 8;
            }

            return Out;
        }
    }
}