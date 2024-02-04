namespace AssetTool
{
    [Location("void UPrimitiveComponent::Serialize(FArchive& Ar)")]
    public class UPrimitiveComponent : USceneComponent
    {
    }

    public static class UPrimitiveComponentExt
    {
        public static void Write(this BinaryWriter writer, UPrimitiveComponent item)
        {
            writer.Write((USceneComponent)item);
        }

        public static UPrimitiveComponent Read(this BinaryReader reader, UPrimitiveComponent item)
        {
            reader.Read((USceneComponent)item);
            return item;
        }
    }
}
