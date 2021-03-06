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
using System.Buffers;
using System.IO;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    /// <summary>The context needed per (de)serialization process, only use one SerializationContext per thread. As the resource are not thread safe</summary>
    /// <remarks>This object cannot be shared among different threads</remarks>
    public partial class SerializationContext {
        /// <summary>Creates a new instance of <see cref="SerializationContext"/></summary>
        public SerializationContext() {
            this.Buffer = ArrayPool<Byte>.Shared.Rent(8);
            this._Renting = true;
            this.Stream = null;
            this.Endianness = Endianness.LittleEndian;
        }

        /// <summary>Creates a new instance of <see cref="SerializationContext"/></summary>
        /// <param name="endianness">The endianness of the NBt structure</param>
        /// <param name="stream">The stream for reading/writing</param>
        public SerializationContext(Endianness endianness, Stream stream) {
            this.Buffer = ArrayPool<Byte>.Shared.Rent(8);
            this._Renting = true;
            this.Endianness = endianness;
            this.Stream = stream;
        }

        /// <summary>Deconstructs the current <see cref="SerializationContext"/></summary>
        ~SerializationContext() {
            this.Dispose(false);
        }
    }
}
