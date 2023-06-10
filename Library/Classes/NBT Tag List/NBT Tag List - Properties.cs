/*ISC License

Copyright (c) 2019, Daan Verstraten */

namespace DaanV2.NBT; 
public sealed partial class NBTTagList : NBTTag {
    /// <summary>Gets or sets the sub type of this this <see cref="ITag"/></summary>
    public NBTTagType SubType { get => this._SubType; set => this._SubType = value; }
}
