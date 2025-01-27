using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    public class FAttributeStorage : ITransferible
    {
        public UInt64 FragmentedMemoryCost;
        public float DefragRatio;
        public Dictionary<AttributeStorageFAttributeKey, FAttributeAllocationInfo> AttributeAllocationTable;
        public TArray64<TUInt8> AttributeStorage;

        [Location("friend FArchive& operator<<(FArchive& Ar, FAttributeStorage& Storage)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref FragmentedMemoryCost);
            transfer.Move(ref DefragRatio);
            transfer.Move(ref AttributeAllocationTable);
            transfer.Move(ref AttributeStorage);
            return this;
        }
    }

    public class FAttributeAllocationInfo : ITransferible
    {
        public UInt64 Offset;
        public UInt64 Size;
        public EAttributeTypes Type;
        public EAttributeProperty Property;
        public FGuid Hash;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Offset);
            transfer.Move(ref Size);
            Type = (EAttributeTypes)transfer.Move((int)Type);
            Property = (EAttributeProperty)transfer.Move((int)Property);
            transfer.Move(ref Hash);
            return this;
        }
    }

    public class AttributeStorageFAttributeKey : ITransferible
    {
        public FString Key;

        [Location("friend FArchive& operator<<(FArchive& Ar, FAttributeKey& AttributeKey)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Key);
            return this;

        }
    }

    public class AttributeStorageFAttributeKeyJsonConverter : JsonConverter<AttributeStorageFAttributeKey>
    {
        public override AttributeStorageFAttributeKey Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new AttributeStorageFAttributeKey { Key = new FString(reader.GetString()) };
        }
        public override AttributeStorageFAttributeKey ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new AttributeStorageFAttributeKey { Key = new FString(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, AttributeStorageFAttributeKey value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Key.ToString());
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, AttributeStorageFAttributeKey value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Key.ToString());
        }
    }

    public enum EAttributeTypes
    {
        None = 0,
        Bool = 1,
        ByteArray = 2,
        ByteArray64 = 3,
        Color = 4,
        DateTime = 5,
        Double = 6,
        Enum = 7,
        Float = 8,
        Guid = 9,
        Int8 = 10,
        Int16 = 11,
        Int32 = 12,
        Int64 = 13,
        IntRect = 14,
        LinearColor = 15,
        Name = 16,
        RandomStream = 17,
        String = 18,
        Timespan = 19,
        TwoVectors = 20,
        UInt8 = 21,
        UInt16 = 22,
        UInt32 = 23,
        UInt64 = 24,
        Vector2d = 25,
        IntPoint = 26,
        IntVector = 27,
        Vector2DHalf = 28,
        Float16 = 29,
        OrientedBox = 30,
        FrameNumber = 31,
        FrameRate = 32,
        FrameTime = 33,
        SoftObjectPath = 34,
        Matrix44f = 35,
        Matrix44d = 36,
        Plane4f = 37,
        Plane4d = 38,
        Quat4f = 39,
        Quat4d = 40,
        Rotator3f = 41,
        Rotator3d = 42,
        Transform3f = 43,
        Transform3d = 44,
        Vector3f = 45,
        Vector3d = 46,
        Vector2f = 47,
        Vector4f = 48,
        Vector4d = 49,
        Box2f = 50,
        Box2D = 51,
        Box3f = 52,
        Box3d = 53,
        BoxSphereBounds3f = 54,
        BoxSphereBounds3d = 55,
        Sphere3f = 56,
        Sphere3d = 57,
        Max = 58
    }

    public enum EAttributeProperty : uint32
    {
        None = 0x0,
        NoHash = 0x1,
    }
}
