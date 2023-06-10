
namespace DaanV2.NBT.Serialization;
/// <summary>The context needed per (de)serialization process, only use one SerializationContext per thread. As the resource are not thread safe</summary>
/// <remarks>This object cannot be shared among different threads</remarks>
public partial class SerializationContext {
    /// <summary>Creates a new instance of <see cref="SerializationContext"/></summary>
    public SerializationContext() {
        this.Stream = null;
        this.Endian = NBT.Endian.Little;
    }

    /// <summary>Creates a new instance of <see cref="SerializationContext"/></summary>
    /// <param name="Endian">The Endian of the NBt structure</param>
    /// <param name="stream">The stream for reading/writing</param>
    public SerializationContext(Endian Endian, Stream stream) {
        this.Endian = Endian;
        this.Stream = stream;
    }
}
