using System.Collections;
using System.Collections.Generic;

namespace DaanV2.NBT; 
public sealed partial class NBTTagCompound : IEnumerable<ITag> {
    /// <summary>Returns an enumerator that iterates through <see cref="NBTTagCompound"/></summary>
    /// <returns>Returns an enumerator that iterates through <see cref="NBTTagCompound"/></returns>
    public IEnumerator<ITag> GetEnumerator() {
        return this._Tags.GetEnumerator();
    }

    /// <summary>Returns an enumerator that iterates through <see cref="NBTTagCompound"/></summary>
    /// <returns>Returns an enumerator that iterates through <see cref="NBTTagCompound"/></returns>
    IEnumerator IEnumerable.GetEnumerator() {
        return this._Tags.GetEnumerator();
    }
}
