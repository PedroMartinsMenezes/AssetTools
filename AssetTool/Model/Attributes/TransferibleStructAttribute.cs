using System.ComponentModel;
using System.Reflection;

namespace AssetTool
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TransferibleStructAttribute : DescriptionAttribute
    {
        public string TypeName;
        public string TypeName1;
        public string TypeName2;
        public int Size1;
        public int Size2;

        public TransferibleStructAttribute(string typename, string typename1 = null, int size1 = 0, string typename2 = null, int size2 = 0)
        {
            TypeName = typename;
            TypeName1 = typename1;
            Size1 = size1;
            TypeName2 = typename2;
            Size2 = size2;
        }

        public static readonly IEnumerable<Type> Types =
            from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            where t.IsDefined(typeof(TransferibleStructAttribute), false)
            select t;

        public static readonly IEnumerable<(Type, TransferibleStructAttribute)> TypesAndAttributes =
            from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            where t.IsDefined(typeof(TransferibleStructAttribute), false)
            select (t, t.GetCustomAttribute<TransferibleStructAttribute>());
    }
}
