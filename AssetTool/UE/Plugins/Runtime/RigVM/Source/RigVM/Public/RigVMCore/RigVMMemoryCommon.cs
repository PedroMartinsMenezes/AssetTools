using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    public class FRigVMOperand : ITransferable
    {
        public ERigVMMemoryType MemoryType;
        public UInt16 RegisterIndex;
        public UInt16 RegisterOffset;

        [Location("void FRigVMOperand::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref MemoryType);
            transfer.Move(ref RegisterIndex);
            transfer.Move(ref RegisterOffset);
            return this;
        }
    }

    public class FRigVMOperandJsonConverter : JsonConverter<FRigVMOperand>
    {
        public override FRigVMOperand Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string[] v = reader.GetString()!.Split(' ');
            return new FRigVMOperand { MemoryType = Enum.Parse<ERigVMMemoryType>(v[0]), RegisterIndex = UInt16.Parse(v[1]), RegisterOffset = UInt16.Parse(v[2]) };
        }
        public override FRigVMOperand ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, FRigVMOperand value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.MemoryType} {value.RegisterIndex} {value.RegisterOffset}");
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FRigVMOperand value, JsonSerializerOptions options)
        {
            writer.WritePropertyName($"{value.MemoryType} {value.RegisterIndex} {value.RegisterOffset}");
        }
    }

    public enum ERigVMMemoryType : byte
    {
        Work = 0,
        Literal = 1,
        External = 2,
        Debug = 3,
        Invalid
    };
}
