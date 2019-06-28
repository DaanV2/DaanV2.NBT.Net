using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT.Compression {
    public partial class ZlibStream : ComponentAce.Compression.Libs.zlib.ZOutputStream {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 ReadByte() {
            if (this.Position > this.Length)
                return -1;

            byte[] Buffer = new byte[1];
            this.Read(Buffer, 0, 1);
            return Buffer[0];
        }
    }
}
