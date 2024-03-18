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

        public FField Read(BinaryReader reader)
        {
            reader.Read(ref NamePrivate);
            reader.Read(ref FlagsPrivate);
            reader.Read(ref HasMetaData);
            if (HasMetaData?.Value == true)
            {
                MetaDataMap = [];
                int count = reader.ReadInt32();
                for (int i = 0; i < count; i++)
                {
                    FName key = new();
                    reader.Read(ref key);
                    FString value = new();
                    reader.Read(ref value);
                    MetaDataMap.Add(key, value);
                }
            }
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(NamePrivate);
            writer.Write(FlagsPrivate);
            writer.Write(HasMetaData);
            if (HasMetaData?.Value == true)
            {
                writer.Write(MetaDataMap.Count);
                foreach (var pair in MetaDataMap)
                {
                    writer.Write(pair.Key);
                    writer.Write(pair.Value);
                }
            }
        }
    }
}
