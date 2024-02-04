namespace AssetTool
{
    [Location("void UMovementComponent::Serialize(FArchive& Ar)")]
    public class UNavMovementComponent : UMovementComponent
    {
    }

    public static class UNavMovementComponentExt
    {
        public static void Write(this BinaryWriter writer, UNavMovementComponent item)
        {
            writer.Write((UMovementComponent)item);
        }

        public static UNavMovementComponent Read(this BinaryReader reader, UNavMovementComponent item)
        {
            reader.Read((UMovementComponent)item);
            return item;
        }
    }
}
