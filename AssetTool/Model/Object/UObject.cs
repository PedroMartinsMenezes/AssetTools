using System.ComponentModel;
using System.Text.Json.Serialization;

namespace AssetTool.Model
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(UMetadata), "UMetadata")]
    [JsonDerivedType(typeof(UUserDefinedStruct), "UUserDefinedStruct")]
    [JsonDerivedType(typeof(UUserDefinedStructEditorData), "UUserDefinedStructEditorData")]
    [JsonDerivedType(typeof(UActorComponent), "UActorComponent")]
    [Description("void UObject::Serialize(FStructuredArchive::FRecord Record)")]
    public class UObject
    {
        [JsonPropertyOrder(-9)] public List<FPropertyTag> Tags = new();
        [JsonPropertyOrder(-9)] public FBool HasGuid = new();
        [JsonPropertyOrder(-9)] public FGuid Guid; //TODO Declare like: Conditional<FGuid> Guid
    }

    public static class UObjectExt
    {
        public static void Write(this BinaryWriter writer, UObject item)
        {
            writer.Write(item.Tags);
            writer.Write(item.HasGuid);
            if (item.HasGuid.Value)
            {
                writer.Write(item.Guid);
            }
        }

        public static UObject Read(this BinaryReader reader, UObject item)
        {
            reader.Read(item.Tags);
            reader.Read(ref item.HasGuid);
            if (item.HasGuid.Value)
            {
                item.Guid = reader.Read(item.Guid);
            }
            return item;
        }
    }
}
