using System.Text.Json.Serialization;
using System.Text.Json;
using System.Diagnostics;

namespace AssetTool
{
    [TransferableStruct("ManagedArrayCollection")]
    public class FManagedArrayCollection : ITransferable
    {
        public Int32 Version;
        public Dictionary<FName, FGroupInfo> TmpGroupInfo;
        public Dictionary<TTuple<FName, FName>, FValueType> TmpMap;

        [Location("bool FManagedArrayCollection::Serialize(FArchive& Ar)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            return transfer.Supports.AddManagedArrayCollectionPropertySerialization ? Move2(transfer) : null;
        }

        [Location("void FManagedArrayCollection::Serialize(Chaos::FChaosArchive& Ar)")]
        public ITransferable Move2(Transfer transfer)
        {
            transfer.Move(ref Version);
            transfer.Move(ref TmpGroupInfo);
            transfer.Move(ref TmpMap);
            return this;
        }
    }

    [DebuggerDisplay("{Version}, {Size}")]
    public class FGroupInfo : ITransferable
    {
        public int Version;
        public int32 Size;

        [Location("FArchive& operator<<(FArchive& Ar, FManagedArrayCollection::FGroupInfo& GroupInfo)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Version);
            transfer.Move(ref Size);
            return this;
        }
    }

    public class FGroupInfoJsonConverter : JsonConverter<FGroupInfo>
    {
        public override FGroupInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ');
            return new FGroupInfo { Version = int.Parse(v[0]), Size = Int32.Parse(v[1]) };
        }
        public override FGroupInfo ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, FGroupInfo value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.Version} {value.Size}");
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FGroupInfo value, JsonSerializerOptions options)
        {
            writer.WritePropertyName($"{value.Version} {value.Size}");
        }
    }

    [DebuggerDisplay("{ArrayType}")]
    public class FValueType : ITransferable
    {
        public int SerializationVersion;
        public int ArrayTypeAsInt;
        public EManagedArrayType ArrayType;
        public int ArrayScopeAsInt;
        public FName GroupIndexDependency;
        public FBool bPersistent;
        public FManagedArrayBase ManagedArray;

        [Location("void FManagedArrayCollection::FValueType::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref SerializationVersion);
            transfer.Move(ref ArrayTypeAsInt);
            ArrayType = (EManagedArrayType)ArrayTypeAsInt;
            if (SerializationVersion < 4)
            {
                transfer.Move(ref ArrayScopeAsInt);
            }
            if (SerializationVersion >= 2)
            {
                transfer.Move(ref GroupIndexDependency);
                transfer.Move(ref bPersistent);
            }
            bool bNewSavedBehavior = transfer.Supports.ManagedArrayCollectionAlwaysSerializeValue;
            if (bNewSavedBehavior || bPersistent)
            {
                ManagedArray ??= new FManagedArrayBase(ArrayType);
                transfer.Move(ref ManagedArray);
            }
            return this;
        }
    }
}