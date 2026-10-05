using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FRigElementKey : ITransferable
    {
        public FName TypeName;
        public FName Name;
        public ERigElementType Type;

        [Location("void FRigElementKey::Load(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref TypeName);

            Type = (ERigElementType)Enum.Parse(typeof(ERigElementType), TypeName.Value.Split("::")[1]);

            transfer.Move(ref Name);
            return this;
        }
    }

    public class FRigElementKeyJsonConverter : JsonConverter<FRigElementKey>
    {
        public override FRigElementKey Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string[] parts = reader.GetString().Split(" | ");
            return new FRigElementKey { TypeName = new FName(parts[0]), Name = new FName(parts[1]), Type = Enum.Parse<ERigElementType>(parts[2]) };
        }

        public override FRigElementKey ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }

        public override void Write(Utf8JsonWriter writer, FRigElementKey value, JsonSerializerOptions options)
        {
            string key = $"{value.TypeName.ToString()} | {value.Name.ToString()} | {value.Type}";
            writer.WriteStringValue(key);
        }

        public override void WriteAsPropertyName(Utf8JsonWriter writer, FRigElementKey value, JsonSerializerOptions options)
        {
            string key = $"{value.TypeName.ToString()} | {value.Name.ToString()} | {value.Type}";
            writer.WritePropertyName(key);
        }
    }

    public class FRigControlLimitEnabled : ITransferable
    {
        public bool bMinimum;
        public bool bMaximum;

        [Location("void FRigControlLimitEnabled::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bMinimum);
            transfer.Move(ref bMaximum);
            return this;
        }
    }

    public class FRigControlValue : ITransferable
    {
        public FRigControlValueStorage FloatStorage;

        [Location("FArchive& operator<<(FArchive& Ar, FRigControlValue& Value)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref FloatStorage);
            return this;
        }
    }

    public class FRigControlValueStorage : ITransferable
    {
        public float Float00;
        public float Float01;
        public float Float02;
        public float Float03;
        public float Float10;
        public float Float11;
        public float Float12;
        public float Float13;
        public float Float20;
        public float Float21;
        public float Float22;
        public float Float23;
        public float Float30;
        public float Float31;
        public float Float32;
        public float Float33;
        public float Float00_2;
        public float Float01_2;
        public float Float02_2;
        public float Float03_2;
        public float Float10_2;
        public float Float11_2;
        public float Float12_2;
        public float Float13_2;
        public float Float20_2;
        public float Float21_2;
        public float Float22_2;
        public float Float23_2;
        public float Float30_2;
        public float Float31_2;
        public float Float32_2;
        public float Float33_2;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Float00);
            transfer.Move(ref Float01);
            transfer.Move(ref Float02);
            transfer.Move(ref Float03);
            transfer.Move(ref Float10);
            transfer.Move(ref Float11);
            transfer.Move(ref Float12);
            transfer.Move(ref Float13);
            transfer.Move(ref Float20);
            transfer.Move(ref Float21);
            transfer.Move(ref Float22);
            transfer.Move(ref Float23);
            transfer.Move(ref Float30);
            transfer.Move(ref Float31);
            transfer.Move(ref Float32);
            transfer.Move(ref Float33);
            transfer.Move(ref Float00_2);
            transfer.Move(ref Float01_2);
            transfer.Move(ref Float02_2);
            transfer.Move(ref Float03_2);
            transfer.Move(ref Float10_2);
            transfer.Move(ref Float11_2);
            transfer.Move(ref Float12_2);
            transfer.Move(ref Float13_2);
            transfer.Move(ref Float20_2);
            transfer.Move(ref Float21_2);
            transfer.Move(ref Float22_2);
            transfer.Move(ref Float23_2);
            transfer.Move(ref Float30_2);
            transfer.Move(ref Float31_2);
            transfer.Move(ref Float32_2);
            transfer.Move(ref Float33_2);
            return this;
        }
    }

    public class FRigHierarchySerializationSettings : ITransferable
    {
        public FControlRigObjectVersion.Enums ControlRigVersion;
        public bool bIsSerializingToPackage;
        public bool bUseCompressedArchive;
        public bool bStoreCompactTransforms;
        public bool bSerializeLocalTransform;
        public bool bSerializeGlobalTransform;
        public bool bSerializeInitialTransform;
        public bool bSerializeCurrentTransform;
        public ESerializationPhase SerializationPhase;

        [Location("void FRigHierarchySerializationSettings::Load(FArchive& InArchive)")]
        public ITransferable Move(Transfer transfer) //1440325
        {
            transfer.MoveEnum(ref ControlRigVersion);
            transfer.Move(ref bIsSerializingToPackage);
            transfer.Move(ref bUseCompressedArchive);
            transfer.Move(ref bStoreCompactTransforms);
            transfer.Move(ref bSerializeLocalTransform);
            transfer.Move(ref bSerializeGlobalTransform);
            transfer.Move(ref bSerializeInitialTransform);
            transfer.Move(ref bSerializeCurrentTransform);
            transfer.MoveEnum(ref SerializationPhase);
            return this;
        }
    }

    public class FRigHierarchyKey : ITransferable
    {
        public bool bIsElement;
        public FRigElementKey ElementKey;
        public bool bIsComponent;
        public FRigComponentKey ComponentKey;

        [Location("void FRigHierarchyKey::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bIsElement);
            if (bIsElement)
            {
                transfer.Move(ref ElementKey);
            }
            transfer.Move(ref bIsComponent);
            if (bIsComponent)
            {
                transfer.Move(ref ComponentKey);
            }
            return this;
        }
    }

    public class FRigComponentKey : ITransferable
    {
        public FName Name;
        public FRigElementKey ElementKey;

        [Location("void FRigComponentKey::Load(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref ElementKey);
            return this;
        }
    }

    public enum ERigMetadataType : byte
    {
        Bool,
        BoolArray,
        Float,
        FloatArray,
        Int32,
        Int32Array,
        Name,
        NameArray,
        Vector,
        VectorArray,
        Rotator,
        RotatorArray,
        Quat,
        QuatArray,
        Transform,
        TransformArray,
        LinearColor,
        LinearColorArray,
        RigElementKey,
        RigElementKeyArray,
        Invalid
    }

    [Flags]
    public enum ERigElementType : byte
    {
        None = 0,
        Bone = 0x001,
        Null = 0x002,
        Space = Null,
        Control = 0x004,
        Curve = 0x008,
        Physics = 0x010,
        Reference = 0x020,
        Connector = 0x040,
        Socket = 0x080,

        First = Bone,
        Last = Socket,
        All = Bone | Null | Control | Curve | Physics | Reference | Connector | Socket,
        ToResetAfterConstructionEvent = Bone | Control | Curve | Socket
    }
}
