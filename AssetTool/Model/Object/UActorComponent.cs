namespace AssetTool
{
    [Location("void UActorComponent::Serialize(FArchive& Ar)")]
    public class UActorComponent : UObject
    {
        [Sized] public List<FSimpleMemberReference> UCSModifiedProperties = new();
    }

    public static class UActorComponentExt
    {
        public static void Write(this BinaryWriter writer, UActorComponent item)
        {
            writer.Write((UObject)item);
            writer.WriteValue(item);
        }

        public static UActorComponent Read(this BinaryReader reader, UActorComponent item)
        {
            reader.Read((UObject)item);

            item.UCSModifiedProperties.Resize(reader.ReadInt32());//My 69927 . 69915

            foreach (var obj in item.UCSModifiedProperties)
            {
                reader.ReadValue(obj);
            }

            return item;
        }
    }
}
