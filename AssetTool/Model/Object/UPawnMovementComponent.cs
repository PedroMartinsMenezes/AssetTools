namespace AssetTool
{
    [Location("void UPawnMovementComponent::Serialize(FArchive& Archive)")]
    public class UPawnMovementComponent : UNavMovementComponent
    {
    }

    public static class UPawnMovementComponentExt
    {
        public static void Write(this BinaryWriter writer, UPawnMovementComponent item)
        {
            writer.Write((UNavMovementComponent)item);
        }

        public static UPawnMovementComponent Read(this BinaryReader reader, UPawnMovementComponent item)
        {
            reader.Read((UNavMovementComponent)item);
            return item;
        }
    }
}
