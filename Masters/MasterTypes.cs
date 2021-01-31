using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4DJ_Tools.Masters
{
    public static partial class MasterTypes
    {
        public static Type GetDeserializeType(string name)
        {
            if (specialTypes.ContainsKey(name))
                return specialTypes[name];

            // Default to Dictionary<int, name>
            return Type.GetType($"System.Collections.Generic.Dictionary`2[System.Int32, D4DJ_Tools.Masters.{name}]");
        }
    }
}
