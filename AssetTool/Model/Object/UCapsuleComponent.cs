using System.ComponentModel;

namespace AssetTool.Model
{
    [Description("void UCapsuleComponent::Serialize(FArchive& Ar)")]
    public class UCapsuleComponent : UShapeComponent
    {
    }

    public static class UCapsuleComponentExt
    {
        public static void Write(this BinaryWriter writer, UCapsuleComponent item)
        {
            writer.Write((USceneComponent)item);
        }

        public static UCapsuleComponent Read(this BinaryReader reader, UCapsuleComponent item)
        {
            reader.Read((USceneComponent)item);
            return item;
        }
    }
}
