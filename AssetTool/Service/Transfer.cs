using AssetTool.Service;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public abstract class Transfer
    {
        public BinaryReader reader; //@@@ remove
        public BinaryWriter writer; //@@@ remove
        public bool IsMoveStream { get; set; }
        public GlobalNames GlobalNames { get; set; } = new();
        public GlobalObjects GlobalObjects { get; set; } = new();
        public Supports Supports { get; set; }
        public SupportsAfter SupportsAfter { get; set; }
        public JsonSerializerOptions options => _options;

        private void SetTransfer(Transfer other)
        {
            SetOptions(other);

            (_options.Converters[0] as FNameJsonConverter).SetTransfer(other);
            (_options.Converters[1] as FObjectImportJsonConverter).SetTransfer(other);
            (_options.Converters[2] as FObjectExportJsonConverter).SetTransfer(other);
            (_options.Converters[3] as NameMapJsonConverter).SetTransfer(other);
            (_options.Converters[4] as SoftObjectPathListJsonConverter).SetTransfer(other);
            (_options.Converters[5] as GatherableTextDataListJsonConverter).SetTransfer(other);
            (_options.Converters[6] as ImportMapJsonConverter).SetTransfer(other);
            (_options.Converters[7] as ExportMapJsonConverter).SetTransfer(other);
            (_options.Converters[8] as FVector3JsonConverter).SetTransfer(other);
        }

        private void SetOptions(Transfer other)
        {
            if (other?.options is { })
            {
                _options = other.options;
                return;
            }
            _options = other.options ?? new JsonSerializerOptions
            {
                TypeInfoResolver = new PolymorphicTypeResolver(),
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
                WriteIndented = true,
                IncludeFields = true,
                Converters =
                {
                    new FNameJsonConverter(),//0
                    new FObjectImportJsonConverter(),//1
                    new FObjectExportJsonConverter(),//2
                    new NameMapJsonConverter(),//3
                    new SoftObjectPathListJsonConverter(),//4
                    new GatherableTextDataListJsonConverter(),//5
                    new ImportMapJsonConverter(),//6
                    new ExportMapJsonConverter(),//7
                    new FVector3JsonConverter(),//8
                    new FNameEntrySerializedJsonConverter(),
                    new FCustomVersionJsonConverter(),
                    new FGuidJsonConverter(),
                    new FStringJsonConverter(),
                    new FNameEntryIdJsonConverter(),
                    new FWeakObjectPtrJsonConverter(),
                    new FBoolJsonConverter(),
                    new FPackageIndexJsonConverter(),
                    new FTextKeyJsonConverter(),
                    new DependsMapJsonConverter(),
                    new FRotatorJsonConverter(),
                    new FRotator3fJsonConverter(),
                    new FRotator3dJsonConverter(),
                    new FDateTimeJsonConverter(),
                    new FColorJsonConverter(),
                    new FVector2JsonConverter(),
                    new FVector2fJsonConverter(),
                    new FVector2dJsonConverter(),
                    new FVector3fJsonConverter(),
                    new FVector3dJsonConverter(),
                    new FVector4JsonConverter(),
                    new FVector4fJsonConverter(),
                    new FVector4dJsonConverter(),
                    new FQuat4JsonConverter(),
                    new FQuat4fJsonConverter(),
                    new FQuat4dJsonConverter(),
                    new FLinearColorJsonConverter(),
                    new FBox2DJsonConverter(),
                    new FBox2dJsonConverter(),
                    new FBox2fJsonConverter(),
                    new FMatrixJsonConverter(),
                    new FMatrix44fJsonConverter(),
                    new FMatrix44dJsonConverter(),
                    new FRigidBodyIndexPairJsonConverter(),
                    new FRigVMGraphFunctionIdentifierJsonConverter(),
                    new AttributeStorageFAttributeKeyJsonConverter(),
                    new TInt8JsonConverter(),
                    new TInt16JsonConverter(),
                    new TInt32JsonConverter(),
                    new TInt64JsonConverter(),
                    new TUInt8JsonConverter(),
                    new TUInt16JsonConverter(),
                    new TUInt32JsonConverter(),
                    new TUInt64JsonConverter(),
                    new TFloatJsonConverter(),
                    new TDoubleJsonConverter(),
                    new PtrJsonConverter(),
                    //Array
                    new FVector2fArrayJsonConverter(),
                    new UInt16ArrayJsonConverter(),
                    new UInt32ArrayJsonConverter(),
                    new TUInt8ArrayJsonConverter(),
                }
            };
        }

        private JsonSerializerOptions _options;

        public void Initialize(Transfer other)
        {
            GlobalNames = other.GlobalNames;
            GlobalObjects = other.GlobalObjects;
            Supports = new Supports(other);
            SupportsAfter = new SupportsAfter(other);
            SetTransfer(other);
        }

        public abstract bool IsReading { get; }
        public abstract bool IsWriting { get; }
        public abstract bool FromJson { get; init; }
        public abstract long Position { get; set; }
        public abstract long Length { get; }
        public abstract long Counter { get; set; }
        public abstract long BaseOffset { get; set; }
        public abstract Stream Stream { get; }

        public abstract void MoveFloat(ref double value);
        public abstract void Move(ref bool value);
        public abstract void Move(ref sbyte value);
        public abstract void Move(ref byte value);
        public abstract void Move(ref short value);
        public abstract void Move(ref ushort value);
        public abstract void Move(ref int value);
        public abstract void Move(ref uint value);
        public abstract void Move(ref long value);
        public abstract void Move(ref ulong value);
        public abstract void Move(ref float value);
        public abstract void Move(ref double value);
        public abstract void MoveSingleOrDouble(ref double value);

        public abstract sbyte Move(sbyte value);
        public abstract byte Move(byte value);
        public abstract short Move(short value);
        public abstract ushort Move(ushort value);
        public abstract int Move(int value);
        public abstract uint Move(uint value);
        public abstract long Move(long value);
        public abstract ulong Move(ulong value);
        public abstract float Move(float value);
        public abstract double Move(double value);

        public abstract void Move(ref float[] value, int size);
        public abstract void Move(ref byte[] value, int size);
        public abstract void Move(ref Int16[] value, int size);
        public abstract void Move(ref UInt16[] value, int size);
        public abstract void Move(ref UInt32[] value, int size);

        public abstract void Move(ref byte[] value);
        public abstract void Move(ref UInt16[] value);
        public abstract void Move(ref Int32[] value);
        public abstract void Move(ref UInt32[] value);
        public abstract void Move(ref UInt64[] value);
        public abstract void Move(ref float[] value);

        public abstract void Move(ref List<sbyte> value);
        public abstract void Move(ref List<byte> value);
        public abstract void Move(ref List<Int16> value);
        public abstract void Move(ref List<UInt16> value);
        public abstract void Move(ref List<Int32> value);
        public abstract void Move(ref List<UInt32> value);
        public abstract void Move(ref List<float> value);

        public abstract void MoveObject<T>(ref T value) where T : UObject;

        public abstract void Move<T>(ref T value) where T : ITransferible;
        public abstract void MoveRaw<T>(ref T value) where T : ITransferibleRaw;
        public abstract void Move<T>(ref List<T> value) where T : ITransferible, new();
        public abstract void Move<T>(ref List<T> value, ref int elementSize) where T : ITransferible, new();
        public abstract void Move<T>(ref List<T> value, int count) where T : ITransferible, new();
        public abstract void Move<T>(ref T[] value) where T : ITransferible;
        public abstract void Move<T>(ref T[] value, int size) where T : ITransferible;
        public abstract void Move<T1, T2>(ref Dictionary<T1, T2> value) where T1 : ITransferible where T2 : ITransferible;
        public abstract void Move<T1, T2>(ref Dictionary<T1, List<T2>> value) where T1 : ITransferible where T2 : ITransferible;

        public abstract void Move<T>(ref List<T> value, Action<T> action) where T : new();
        public abstract void Move<T1, T2>(ref Dictionary<T1, T2> value, Action<T1> act1, Action<T2> act2) where T1 : new() where T2 : new();

        public abstract void Move(ref FBool value);
        public abstract FGuid Move(FGuid value);
        public abstract void Move(ref FGuid value);
        public abstract FName Move(FName value);
        public abstract void Move(ref FName value);
        public abstract FString Move(FString value);
        public abstract void Move(ref FString value);
        public abstract FText Move(FText value);
        public abstract void Move(ref FText value);
        public abstract void Move(ref FTextKey value);
    }
}
