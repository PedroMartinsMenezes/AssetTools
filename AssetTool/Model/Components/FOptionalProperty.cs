using System.ComponentModel;

namespace AssetTool
{
    [Description("void FOptionalProperty::Serialize(FArchive& Ar)")]
    public class FOptionalProperty : FProperty
    {
        
    }

    public static class FOptionalPropertyExt
    {
        public static void Write(this BinaryWriter writer, FOptionalProperty item)
        {
            
        }

        public static void Read(this BinaryReader reader, FOptionalProperty item)
        {
            
        }
    }
}
