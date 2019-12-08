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
        /// <summary>Writes an array of <see cref="Byte"/> into the <see cref="Stream"/></summary>
        /// <param name="stream">The <see cref="Stream"/> to write to</param>
        /// <param name="Buffer">The buffer to write to stream</param>
        public static void WriteBytes(this Stream stream, Byte[] Buffer) {
            stream.Write(Buffer, 0, Buffer.Length);
        }

        /// <summary>Writes an <see cref="Int16"/> into the <see cref="Stream"/></summary>
        /// <param name="stream">The <see cref="Stream"/> to write to</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        public static void WriteInt16(this Stream stream, Int16 Value) {
            Byte[] Buffer = BitConverter.GetBytes(Value);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            stream.Write(Buffer, 0, Buffer.Length);
        }

        /// <summary>Writes an <see cref="Int32"/> into the <see cref="Stream"/></summary>
        /// <param name="stream">The <see cref="Stream"/> to write to</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        public static void WriteInt32(this Stream stream, Int32 Value) {
            Byte[] Buffer = BitConverter.GetBytes(Value);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            stream.Write(Buffer, 0, Buffer.Length);
        }

        /// <summary>Writes an <see cref="Int64"/> into the <see cref="Stream"/></summary>
        /// <param name="stream">The <see cref="Stream"/> to write to</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        public static void WriteInt64(this Stream stream, Int64 Value) {
            Byte[] Buffer = BitConverter.GetBytes(Value);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            stream.Write(Buffer, 0, Buffer.Length);
        }

        /// <summary>Writes an <see cref="Single"/> into the <see cref="Stream"/></summary>
        /// <param name="stream">The <see cref="Stream"/> to write to</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        public static void WriteFloat(this Stream stream, Single Value) {
            Byte[] Buffer = BitConverter.GetBytes(Value);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            stream.Write(Buffer, 0, Buffer.Length);
        }

        /// <summary>Writes an <see cref="Double"/> into the <see cref="Stream"/></summary>
        /// <param name="stream">The <see cref="Stream"/> to write to</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        public static void WriteDouble(this Stream stream, Double Value) {
            Byte[] Buffer = BitConverter.GetBytes(Value);

            if (BitConverter.IsLittleEndian) {
                Array.Reverse(Buffer);
            }

            stream.Write(Buffer, 0, Buffer.Length);
        }

        /// <summary>Writes an array of <see cref="Int32"/> into the <see cref="Stream"/></summary>
        /// <param name="stream">The <see cref="Stream"/> to write to</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        public static void WriteInt32Array(this Stream stream, Int32[] Value) {
            Byte[] Buffer;

            for (Int32 I = 0; I < Value.Length; I++) {
                Buffer = BitConverter.GetBytes(Value[I]);

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(Buffer);
                }

                stream.Write(Buffer, 0, Buffer.Length);
            }
        }

        /// <summary>Writes an array of <see cref="Int64"/> into the <see cref="Stream"/></summary>
        /// <param name="stream">The <see cref="Stream"/> to write to</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        public static void WriteInt64Array(this Stream stream, Int64[] Value) {
            Byte[] Buffer;

            for (Int32 I = 0; I < Value.Length; I++) {
                Buffer = BitConverter.GetBytes(Value[I]);

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(Buffer);
                }

                stream.Write(Buffer, 0, Buffer.Length);
            }
        }
    }
}
