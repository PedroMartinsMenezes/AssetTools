using System.ComponentModel;
using System.Reflection;

namespace AssetTool.Model
{
    [Description("void UActorComponent::Serialize(FArchive& Ar)")]
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

            item.UCSModifiedProperties.Resize(reader.ReadInt32());
            item.UCSModifiedProperties.ForEach(x => reader.ReadValue(x));

            return item;
        }
    }
}
