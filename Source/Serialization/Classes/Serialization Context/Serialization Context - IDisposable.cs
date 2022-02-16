/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Buffers;

namespace DaanV2.NBT.Serialization {
    public partial class SerializationContext : IDisposable {
        ///DOLATER <summary>Add Description</summary>
        public void Dispose() {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Value">FILL IN</param>
        protected virtual void Dispose(Boolean Value) {
            if (this._Renting) {
                if (this.Buffer is not null) {

                    ArrayPool<Byte>.Shared.Return(this.Buffer);
                    this.Buffer = null;
                }

                this._Renting = false;
            }
        }
    }
}
