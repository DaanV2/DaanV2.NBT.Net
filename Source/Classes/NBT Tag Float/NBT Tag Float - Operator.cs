﻿/*ISC License

Copyright (c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;

namespace DaanV2.NBT {
    public sealed partial class NBTTagFloat {
        /// <summary>Compare two objects to one another to see if they are equal</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare two objects to one another to see if they are equal</returns>
        public static Boolean operator ==(NBTTagFloat A, NBTTagFloat B) {
            Boolean NA = ((Object)A) == null;
            Boolean NB = ((Object)B) == null;

            if (NA && NB) { return true; }
            if (NA || NB) { return false; }

            return A.Equals(B);
        }

        /// <summary>Compare two objects to one another to see if they are not equal</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare two objects to one another to see if they are not equal</returns>
        public static Boolean operator !=(NBTTagFloat A, NBTTagFloat B) {
            return !(A == B);
        }

        /// <summary>Compare two objects to one another to see if they are equal</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare two objects to one another to see if they are equal</returns>
        public static Boolean operator ==(NBTTagFloat A, Object B) {
            Boolean NA = ((Object)A) == null;
            Boolean NB = ((Object)B) == null;

            if (NA && NB) { return true; }
            if (NA || NB) { return false; }

            return A.Equals(B);
        }

        /// <summary>Compare two objects to one another to see if they are not equal</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare two objects to one another to see if they are not equal</returns>
        public static Boolean operator !=(NBTTagFloat A, Object B) {
            return !(A == B);
        }
    }
}
