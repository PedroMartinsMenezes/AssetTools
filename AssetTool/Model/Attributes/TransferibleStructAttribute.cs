using System.ComponentModel;
using System.Reflection;

namespace AssetTool
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TransferibleStructAttribute : DescriptionAttribute
    {
        public string TypeName;

        public TransferibleStructAttribute(string value) : base(value)
        {
            TypeName = value;
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
