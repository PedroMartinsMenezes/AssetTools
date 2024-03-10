namespace AssetTool
{
    [Location("void UAudioComponent::Serialize(FArchive& Ar)")]
    public class UAudioComponent : USceneComponent
    {
        public new const string TypeName = "AudioComponent";
    }

    public static class UAudioComponentExt
    {
        public static void Write(this BinaryWriter writer, UAudioComponent item)
        {
            writer.Write((USceneComponent)item);
        }

        public static UAudioComponent Read(this BinaryReader reader, UAudioComponent item)
        {
            reader.Read((USceneComponent)item);
            return item;
        }
    }
}
