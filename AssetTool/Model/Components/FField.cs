using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void FField::Serialize(FArchive& Ar)")]
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(FProperty), "FProperty")]
    [JsonDerivedType(typeof(FIntProperty), "FIntProperty")]
    [JsonDerivedType(typeof(FFloatProperty), "FFloatProperty")]
    [JsonDerivedType(typeof(FDoubleProperty), "FDoubleProperty")]
    [JsonDerivedType(typeof(FEnumProperty), "FEnumProperty")]
    [JsonDerivedType(typeof(FOptionalProperty), "FOptionalProperty")]
    [JsonDerivedType(typeof(FBoolProperty), "FBoolProperty")]
    [JsonDerivedType(typeof(FObjectPropertyBase), "FObjectPropertyBase")]
    [JsonDerivedType(typeof(FStructProperty), "FStructProperty")]
    [JsonDerivedType(typeof(FMulticastDelegateProperty), "FMulticastDelegateProperty")]
    [JsonDerivedType(typeof(FInterfaceProperty), "FInterfaceProperty")]
    [JsonDerivedType(typeof(FStrProperty), "FStrProperty")]
    public class FField
    {
        public virtual string TypeName { get; }

        protected FName PropertyTypeName;

        public FName NamePrivate;
        public UInt32 FlagsPrivate;
        public Dictionary<FName, FString> MetaDataMap;
        public FBool HasMetaData;
    }

    public static class FFieldExt
    {
        public static void Write(this BinaryWriter writer, FField item)
        {
            writer.Write(item.NamePrivate);
            writer.Write(item.FlagsPrivate);
            writer.Write(item.HasMetaData);
            if (item.HasMetaData?.Value == true)
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
            reader.Read(ref item.NamePrivate);
            reader.Read(ref item.FlagsPrivate);
            reader.Read(ref item.HasMetaData);
            if (item.HasMetaData?.Value == true)
            {
                item.MetaDataMap = [];
                int count = reader.ReadInt32();
                for (int i = 0; i < count; i++)
                {
                    FName key = new();
                    reader.Read(ref key);
                    FString value = new();
                    reader.Read(ref value);
                    item.MetaDataMap.Add(key, value);
                }
            }
            return item;
        }
    }
}
