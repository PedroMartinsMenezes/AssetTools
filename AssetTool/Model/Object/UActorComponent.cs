using System.ComponentModel;
using System.Reflection.PortableExecutable;

namespace AssetTool.Model
{
    [Description("void UActorComponent::Serialize(FArchive& Ar)")]
    public class UActorComponent : UObject
    {
        [Sized]
        public List<FSimpleMemberReference> UCSModifiedProperties;

    }

    public static class UActorComponentExt
    {
        public static void Write(this BinaryWriter writer, UActorComponent item)
        {
            writer.Write((UObject)item);
            writer.WriteValue(item.UCSModifiedProperties);
        }

        public static UActorComponent Read(this BinaryReader reader, UActorComponent item)
        {
            reader.Read((UObject)item);
            reader.ReadValue(item.UCSModifiedProperties);
            return item;
        }
    }
}
