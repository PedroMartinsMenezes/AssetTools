namespace AssetTool
{
    [Location("void USceneComponent::Serialize(FArchive& Ar)")]
    public class USceneComponent : UActorComponent
    {
    }

    public static class USceneComponentExt
    {
        public static void Write(this BinaryWriter writer, USceneComponent item)
        {
            writer.Write((UActorComponent)item);
        }

        public static USceneComponent Read(this BinaryReader reader, USceneComponent item)
        {
            reader.Read((UActorComponent)item);
            return item;
        }
    }
}
