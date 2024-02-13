namespace AssetTool
{
    [Location("void UCapsuleComponent::Serialize(FArchive& Ar)")]
    public class UCapsuleComponent : UShapeComponent
    {
        public new const string TypeName = "CapsuleComponent";
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
