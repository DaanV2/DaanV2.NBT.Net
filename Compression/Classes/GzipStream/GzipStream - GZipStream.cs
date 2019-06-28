using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT.Compression {
    public partial class GzipStream : System.IO.Compression.GZipStream {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 ReadByte() {
            if (this.BaseStream.Length < this.BaseStream.Position)
                return -1;

            byte[] Buffer = new byte[1];
            this.Read(Buffer, 0, 1);
            return Buffer[0];
        }
    }
}
