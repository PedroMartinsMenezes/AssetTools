using System.Diagnostics;
using System.Text;

namespace AssetTool
{
    //@@@ Remove this class
    [DebuggerDisplay("array[]")]
    public class GenericPropertyJsonArray : BasePropertyJsonArray
    {
        public GenericPropertyJsonArray() { }

        public override string Name => "array[]";
        public override int Size => 0;
        public override string InnerTypeName => FStrProperty.TYPE_NAME;

        public override string FromNativeFields(FPropertyTag tag)
        {
            var fields = new StringBuilder();

            fields.Append($"Size({tag.Size}) ");
            if (tag.InnerType is { }) fields.Append($"InnerType({tag.InnerType}) ");
            if (tag.StructName is { }) fields.Append($"StructName({tag.StructName}) ");
            if (tag.PropertyTagFlags is { }) fields.Append($"PropertyTagFlags({tag.PropertyTagFlags}) ");
            if (tag.PropertyTagExtensions is { }) fields.Append($"PropertyTagExtensions({tag.PropertyTagExtensions}) ");
            if (tag.OverrideOperation is { }) fields.Append($"OverrideOperation({tag.OverrideOperation}) ");
            if (tag.bExperimentalOverridableLogic is { }) fields.Append($"bExperimentalOverridableLogic({tag.bExperimentalOverridableLogic}) ");
            if (tag.StructGuid is { }) fields.Append($"StructGuid({tag.StructGuid}) ");

            return fields.ToString();
        }

        public override void ToNativeFields(FPropertyTag tag, string key)
        {
            tag.Size = key.GetNonNull("Size({0})", x => int.Parse(x));
            tag.InnerType = key.GetNonNull("InnerType({0})", x => new FName(x));
            tag.StructName = key.GetNonNull("StructName({0})", x => new FName(x));
            tag.PropertyTagFlags = key.GetNonNull("PropertyTagFlags({0})", x => (EPropertyTagFlags?)Enum.Parse(typeof(EPropertyTagFlags), x));
            tag.PropertyTagExtensions = key.GetNonNull("PropertyTagExtensions({0})", x => (EPropertyTagExtension?)Enum.Parse(typeof(EPropertyTagExtension), x));
            tag.OverrideOperation = key.GetNonNull("OverrideOperation({0})", x => (EOverriddenPropertyOperation?)Enum.Parse(typeof(EOverriddenPropertyOperation), x));
            tag.bExperimentalOverridableLogic = key.GetNonNull("bExperimentalOverridableLogic({0})", x => (bool?)bool.Parse(x));
            tag.StructGuid = key.GetNonNull("StructGuid({0})", x => new FGuid(x));
        }

        public override object FromNativeValue(FPropertyTag tag)
        {
            return tag.Value;
        }

        public override List<object> ToNativeValue(object val)
        {
            return val.ToObject<List<object>>();
        }
    }
}
