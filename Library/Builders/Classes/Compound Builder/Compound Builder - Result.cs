/*ISC License

Copyright (c) 2019, Daan Verstraten */

namespace DaanV2.NBT.Builders {
    public partial class CompoundBuilder {
        /// <summary>Returns the final product of this builder</summary>
        /// <returns>Returns the final product of this builder</returns>
        public NBTTagCompound GetResult() {
            return this._Tag;
        }
    }
}
