using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT {
    ///DOLATER <summary> add description for class: Utillity</summary>
    public static partial class Utillity {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<T> GetInterfaces<T>() {
            List<T> Out = new List<T>(10);
            Type Find = typeof(T);
            Assembly[] Assemblies = AppDomain.CurrentDomain.GetAssemblies();
            Int32 AsmLength = Assemblies.Length;
            Type[] Types;
            Type Current;
            Int32 TypesLength;
            Assembly Asm;

            for (Int32 I = 0; I < AsmLength; I++) {
                Asm = Assemblies[I];

                Types = Asm.GetTypes();
                TypesLength = Types.Length;

                for (Int32 J = 0; J < TypesLength; J++) {
                    Current = Types[J];

                    if (Current.GetInterface(Find.Name) != null) {
                        Out.Add((T)Activator.CreateInstance(Current));
                    }
                }
            }

            return Out;
        }
    }
}
