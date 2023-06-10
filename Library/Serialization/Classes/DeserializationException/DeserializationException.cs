namespace DaanV2.NBT.Serialization;

public partial class DeserializationException : Exception {
    public String? Name { get; set; }
    public NBTTagType Type { get; set; }
    public Int64 Position { get; set; }

    public DeserializationException(String? name, NBTTagType type, Int64 position, Exception innerException)
        : base(Message(name, type, position), innerException) {
        this.Name = name;
        this.Type = type;
        this.Position = position;
    }

    public static String Message(String? name, NBTTagType type, Int64 position) {
        String b = $"Error reading nbt at byte offset: {position}";

        b += $", type: {type}";

        if (name is not null) {
            b += $", name: {name}";
        }

        return b;
    }
}
