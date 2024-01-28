using System.ComponentModel;

namespace AssetTool.Model
{
    [Description("void UCharacterMovementComponent::Serialize(FArchive& Archive)")]
    public class UCharacterMovementComponent : UPawnMovementComponent
    {
    }

    public static class UCharacterMovementComponentExt
    {
        public static void Write(this BinaryWriter writer, UCharacterMovementComponent item)
        {
            writer.Write((UPawnMovementComponent)item);
        }

        public static UCharacterMovementComponent Read(this BinaryReader reader, UCharacterMovementComponent item)
        {
            reader.Read((UPawnMovementComponent)item);
            return item;
        }
    }
}
