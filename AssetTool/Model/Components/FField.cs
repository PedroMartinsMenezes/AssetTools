using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(FProperty), "FProperty")]
    [JsonDerivedType(typeof(FEnumProperty), "FEnumProperty")]
    [JsonDerivedType(typeof(FOptionalProperty), "FOptionalProperty")]
    [JsonDerivedType(typeof(FBoolProperty), "FBoolProperty")]
    [JsonDerivedType(typeof(FObjectPropertyBase), "FObjectPropertyBase")]
    [JsonDerivedType(typeof(FStructProperty), "FStructProperty")]
    [JsonDerivedType(typeof(FMulticastDelegateProperty), "FMulticastDelegateProperty")]
    public class FField
    {
        public FName PropertyTypeName;

        public FName NamePrivate = new();
        public UInt32 FlagsPrivate;
        public Dictionary<FName, FString> MetaDataMap = new();
        public FBool HasMetaData = new();
    }

    public static class FFieldExt
    {
        public static void Write(this BinaryWriter writer, FField item)
        {
            writer.Write(item.NamePrivate);
            writer.Write(item.FlagsPrivate);
            writer.Write(item.HasMetaData);
            if (item.HasMetaData.Value)
            {
                writer.Write(item.MetaDataMap.Count);
                foreach (var pair in item.MetaDataMap)
                {
                    writer.Write(pair.Key);
                    writer.Write(pair.Value);
                }
            }
        }

        public static FField Read(this BinaryReader reader, FField item)
        {
            reader.Read(item.NamePrivate);
            reader.Read(ref item.FlagsPrivate);
            reader.Read(ref item.HasMetaData);
            if (item.HasMetaData.Value)
            {
                item.MetaDataMap.Resize(reader.ReadInt32());
                foreach (var pair in item.MetaDataMap)
                {
                    reader.Read(pair.Key);
                    reader.Read(pair.Value);
                }
            }
            return item;
        }
    }
}
