using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    public partial class SerializationContext {
        /// <summary>
        /// 
        /// </summary>
        public Endianness Endianness { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Byte[] Buffer { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Stream Stream { get; private set; }
    }
}
