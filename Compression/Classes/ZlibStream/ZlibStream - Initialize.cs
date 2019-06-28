using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT.Compression {
    ///DOLATER <summary> add description for class: ZlibStream</summary>
	[Serializable, DataContract]
    public partial class ZlibStream {
        /// <summary>Creates a new instance of <see cref="ZlibStream"/></summary>
        public ZlibStream(Stream stream) : base(stream) { }

        /// <summary>Creates a new instance of <see cref="ZlibStream"/></summary>
        public ZlibStream(Stream stream, int Level) : base(stream, Level) { }
    }
}
