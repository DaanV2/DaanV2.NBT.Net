using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT.Compression {
    ///DOLATER <summary> add description for class: GzipStream</summary>
	[Serializable, DataContract]
    public partial class GzipStream {
        /// <summary>Creates a new instance of <see cref="GzipStream"/></summary>
        public GzipStream(Stream stream, CompressionLevel Level) : base(stream, Level) {
        }

        /// <summary>Creates a new instance of <see cref="GzipStream"/></summary>
        public GzipStream(Stream stream, CompressionMode Mode) : base(stream, Mode) {
        }

        /// <summary>Creates a new instance of <see cref="GzipStream"/></summary>
        public GzipStream(Stream stream, CompressionLevel Level, bool LeaveOpen) : base(stream, Level, LeaveOpen) {
        }

        /// <summary>Creates a new instance of <see cref="GzipStream"/></summary>
        public GzipStream(Stream stream, CompressionMode Mode, bool LeaveOpen) : base(stream, Mode, LeaveOpen) {
        }
    }
}
