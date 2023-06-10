using System;

namespace DaanV2.NBT.Serialization; 
/// <summary>The class that extends upon the <see cref="SerializationContext"/></summary>
public static partial class SerializationContextExtension {
    /// <summary>Returns the amount of bytes a <see cref="Byte"/> uses</summary>
    public const Int32 ByteSize = sizeof(Byte);

    /// <summary>Returns the amount of bytes a <see cref="Int16"/> uses</summary>
    public const Int32 Int16Size = sizeof(Int16);

    /// <summary>Returns the amount of bytes a <see cref="Int32"/> uses</summary>
    public const Int32 Int32Size = sizeof(Int32);

    /// <summary>Returns the amount of bytes a <see cref="Int64"/> uses</summary>
    public const Int32 Int64Size = sizeof(Int64);

    /// <summary>Returns the amount of bytes a <see cref="SByte"/> uses</summary>
    public const Int32 sByteSize = sizeof(SByte);

    /// <summary>Returns the amount of bytes a <see cref="UInt16"/> uses</summary>
    public const Int32 UInt16Size = sizeof(UInt16);

    /// <summary>Returns the amount of bytes a <see cref="UInt32"/> uses</summary>
    public const Int32 UInt32Size = sizeof(UInt32);

    /// <summary>Returns the amount of bytes a <see cref="UInt64"/> uses</summary>
    public const Int32 UInt64Size = sizeof(UInt64);

    /// <summary>Returns the amount of bytes a <see cref="Single"/> uses</summary>
    public const Int32 SingleSize = sizeof(Single);

    /// <summary>Returns the amount of bytes a <see cref="Double"/> uses</summary>
    public const Int32 DoubleSize = sizeof(Double);
}
