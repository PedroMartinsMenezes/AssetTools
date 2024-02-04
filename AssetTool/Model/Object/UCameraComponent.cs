namespace AssetTool
{
    [Location("void UCameraComponent::Serialize(FArchive& Ar)")]
    public class UCameraComponent : USceneComponent
    {
    }

    public static class UCameraComponentExt
    {
        public static void Write(this BinaryWriter writer, UCameraComponent item)
        {
            writer.Write((USceneComponent)item);
        }

        public static UCameraComponent Read(this BinaryReader reader, UCameraComponent item)
        {
            reader.Read((USceneComponent)item);
            return item;
        }
    }
}
