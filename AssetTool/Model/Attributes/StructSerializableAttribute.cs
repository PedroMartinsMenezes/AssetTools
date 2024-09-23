using System.ComponentModel;
using System.Reflection;

namespace AssetTool
{
    [AttributeUsage(AttributeTargets.Class)]
    public class StructSerializableAttribute : DescriptionAttribute
    {
        public string TypeName;

        public StructSerializableAttribute(string value) : base(value)
        {
            TypeName = value;
        }

        public static readonly IEnumerable<Type> Types =
            from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            where t.IsDefined(typeof(StructSerializableAttribute), false)
            select t;

        public static readonly IEnumerable<(Type, StructSerializableAttribute)> TypesAndAttributes =
            from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            where t.IsDefined(typeof(StructSerializableAttribute), false)
            select (t, t.GetCustomAttribute<StructSerializableAttribute>());
    }
}
