namespace AssetTool
{
    [Location("void UShapeComponent::Serialize(FArchive& Ar)")]
    public class UShapeComponent : UPrimitiveComponent
    {
    }

    public static class UShapeComponentExt
    {
        public static void Write(this BinaryWriter writer, UShapeComponent item)
        {
            writer.Write((USceneComponent)item);
        }

        public static UShapeComponent Read(this BinaryReader reader, UShapeComponent item)
        {
            reader.Read((USceneComponent)item);
            return item;
        }
    }
}
