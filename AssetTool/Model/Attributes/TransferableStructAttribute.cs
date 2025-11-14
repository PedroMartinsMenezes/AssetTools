using System.ComponentModel;
using System.Reflection;

namespace AssetTool
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class TransferableStructAttribute : DescriptionAttribute
    {
        public string TypeName;
        public string TypeName1;
        private readonly int Size1;
        private readonly int Size2;

        public int Size(Transfer transfer) => Size2 == 0 ? Size1 : transfer.Supports.LARGE_WORLD_COORDINATES ? Size2 : Size1;

        public TransferableStructAttribute(string typename, string typename1 = default, int size1 = 0, string typename2 = default, int size2 = 0)
        {
            TypeName = typename;
            TypeName1 = typename1;
            Size1 = size1;
            Size2 = size2;
        }

        public static readonly IEnumerable<(Type, TransferableStructAttribute)> TypesAndAttributes =
            from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            where t.IsDefined(typeof(TransferableStructAttribute), false)
            select (t, t.GetCustomAttribute<TransferableStructAttribute>());
    }
}
