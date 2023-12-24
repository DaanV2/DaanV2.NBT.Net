namespace DaanV2.NBT.Serialization;

/// <summary>A exception that is thrown when a nbt file is not valid</summary>
public partial class DeserializationException : Exception {
    /// <summary>The name of the obejct that caused this</summary>
    public String? Name { get; set; }
    /// <summary>The type of the object</summary>
    public NBTTagType Type { get; set; }
    /// <summary>The position in stream / file</summary>
    public Int64 Position { get; set; }

    /// <summary>Creates a new instance of <see cref="DeserializationException"/></summary>
    /// <param name="name"></param>
    /// <param name="type"></param>
    /// <param name="position"></param>
    /// <param name="innerException"></param>
    public DeserializationException(String? name, NBTTagType type, Int64 position, Exception innerException)
        : base(Message(name, type, position), innerException) {
        this.Name = name;
        this.Type = type;
        this.Position = position;
    }

    /// <summary>Creates a message for the given position and type</summary>
    /// <param name="name">The name of the object</param>
    /// <param name="type">The type of the object</param>
    /// <param name="position">The position in stream / file</param>
    /// <returns>A formatted string</returns>
    public new static String Message(String? name, NBTTagType type, Int64 position) {
        String b = $"Error reading nbt at byte offset: {position}";

        b += $", type: {type}";

        if (name is not null) {
            b += $", name: {name}";
        }

        return b;
    }
}
