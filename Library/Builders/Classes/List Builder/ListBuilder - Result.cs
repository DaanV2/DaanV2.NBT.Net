/*ISC License

Copyright (c) 2019, Daan Verstraten */

namespace DaanV2.NBT.Builders; 
public partial class ListBuilder {
    /// <summary>Returns the final product of this builder</summary>
    /// <returns>Returns the final product of this builder</returns>
    public NBTTagList GetResult() {
        return this._Tag;
    }
}
