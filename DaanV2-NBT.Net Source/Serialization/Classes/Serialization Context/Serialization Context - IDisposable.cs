using System;
using System.Buffers;

namespace DaanV2.NBT.Serialization {
    public partial class SerializationContext : IDisposable {
        /// <summary>
        /// 
        /// </summary>
        public void Dispose() {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        protected virtual void Dispose(Boolean Value) {
            if (this._Renting) {
                if (this.Buffer != null) {

                    ArrayPool<Byte>.Shared.Return(this.Buffer);
                    this.Buffer = null;
                }

                this._Renting = false;
            }
        }
    }
}
