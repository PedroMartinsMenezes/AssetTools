using System.ComponentModel;

namespace AssetTool
{
    [Description("void FNumericProperty::Serialize(FArchive& Ar)")]
    public class FNumericProperty : FProperty
    {
        public UInt64 Value;
    }

    public static class FNumericPropertyExt
    {
        public static void Write(this BinaryWriter writer, FNumericProperty item)
        {
            
        }

        public static void Read(this BinaryReader reader, FNumericProperty item)
        {
            
        }
    }
}
