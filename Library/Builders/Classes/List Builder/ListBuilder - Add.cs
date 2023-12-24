using System;

namespace DaanV2.NBT.Builders; 
public partial class ListBuilder {
    /// <summary>Add an item to the list</summary>
    /// <param name="Value">The value of the tag to add to the collection</param>
    public void Add(Byte Value) {
        this.Add(NBTTagFactory.Create(NBTTagType.Byte, String.Empty, Value));
    }

    /// <summary>Add an item to the list</summary>
    /// <param name="Value">The value of the tag to add to the collection</param>
    public void Add(Boolean Value) {
        this.Add(NBTTagFactory.Create(NBTTagType.Byte, String.Empty, (Byte)(Value ? 1 : 0)));
    }

    /// <summary>Add an item to the list</summary>
    /// <param name="Value">The value of the tag to add to the collection</param>
    public void Add(Byte[] Value) {
        this.Add(NBTTagFactory.Create(NBTTagType.ByteArray, String.Empty, Value));
    }

    /// <summary>Add an item to the list</summary>
    /// <param name="Value">The value of the tag to add to the collection</param>
    public void Add(Double Value) {
        this.Add(NBTTagFactory.Create(NBTTagType.Double, String.Empty, Value));
    }

    /// <summary>Add an item to the list</summary>
    /// <param name="Value">The value of the tag to add to the collection</param>
    public void Add(Single Value) {
        this.Add(NBTTagFactory.Create(NBTTagType.Float, String.Empty, Value));
    }

    /// <summary>Add an item to the list</summary>
    /// <param name="Value">The value of the tag to add to the collection</param>
    public void Add(Int32 Value) {
        this.Add(NBTTagFactory.Create(NBTTagType.Int, String.Empty, Value));
    }

    /// <summary>Add an item to the list</summary>
    /// <param name="Value">The value of the tag to add to the collection</param>
    public void Add(Int32[] Value) {
        this.Add(NBTTagFactory.Create(NBTTagType.IntArray, String.Empty, Value));
    }

    /// <summary>Add an item to the list</summary>
    /// <param name="Value">The value of the tag to add to the collection</param>
    public void Add(Int64 Value) {
        this.Add(NBTTagFactory.Create(NBTTagType.Long, String.Empty, Value));
    }

    /// <summary>Add an item to the list</summary>
    /// <param name="Value">The value of the tag to add to the collection</param>
    public void Add(Int64[] Value) {
        this.Add(NBTTagFactory.Create(NBTTagType.LongArray, String.Empty, Value));
    }

    /// <summary>Add an item to the list</summary>
    /// <param name="Value">The value of the tag to add to the collection</param>
    public void Add(Int16 Value) {
        this.Add(NBTTagFactory.Create(NBTTagType.Short, String.Empty, Value));
    }

    /// <summary>Add an item to the list</summary>
    /// <param name="Value">The value of the tag to add to the collection</param>
    public void Add(String Value) {
        this.Add(NBTTagFactory.Create(NBTTagType.String, String.Empty, Value));
    }

    /// <summary>Add a tag to the list</summary>
    /// <param name="Tag">The tag to add</param>
    public void Add(ITag? Tag) {
        if (Tag is null) { return; }

        this._Tag.Add(Tag);
    }

    /// <summary>Adds a new sub <see cref="NBTTagCompound"/> to the collection</summary>
    /// <param name="Name">The name of the tag to add to the collection</param>
    /// <param name="Capacity">The amount of suspected sub items</param>
    /// <returns>Adds a new sub <see cref="NBTTagCompound"/> to the collection</returns>
    public CompoundBuilder AddSubCompound(String Name, Int32 Capacity = 10) {
        var builder = new CompoundBuilder(Name, Capacity);
        this._Tag.Add(builder._Tag);
        return builder;
    }

    /// <summary>Adds a new sub <see cref="NBTTagList"/> to the collection</summary>
    /// <param name="Name">The name of the tag to add to the collection</param>
    /// <param name="SubType">The subtype of the tags inside the list</param>
    /// <param name="Capacity">The capacity to start the list with</param>
    /// <returns>Adds a new sub <see cref="NBTTagList"/> to the collection</returns>
    public ListBuilder AddSubList(String Name, NBTTagType SubType, Int32 Capacity = 10) {
        var Tag = new NBTTagList(Name, SubType, Capacity);
        var Builder = new ListBuilder(Tag);
        this._Tag.Add(Tag);
        return Builder;
    }
}
