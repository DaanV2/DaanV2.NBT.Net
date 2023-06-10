/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;

namespace DaanV2.NBT; 
public abstract partial class NBTTag {
    /// <summary>Any possible sub this <see cref="ITag"/> this <see cref="NBTTag"/> can have</summary>
    protected List<ITag> _Tags;

    /// <summary>The name of this this <see cref="ITag"/></summary>
    protected String _Name;
}
