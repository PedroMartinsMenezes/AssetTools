using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    public class FRigVMGraphFunctionData : ITransferible
    {
        public FRigVMGraphFunctionHeader Header;
        public FRigVMFunctionCompilationData CompilationData;
        public FString SerializedCollapsedNode;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMGraphFunctionData& Data)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Header);
            transfer.Move(ref CompilationData);

            if (!Supports.RigVMSaveSerializedGraphInGraphFunctionData)
                return this;

            transfer.Move(ref SerializedCollapsedNode);
            return this;
        }
    }

    public class FRigVMGraphFunctionHeader : ITransferible
    {
        public FRigVMGraphFunctionIdentifier LibraryPointer;
        public FName Name;
        public FString NodeTitle;
        public FLinearColor NodeColor;
        public FText Tooltip;
        public FString Category;
        public FString Keywords;
        public List<FRigVMGraphFunctionArgument> Arguments;
        public Dictionary<FRigVMGraphFunctionIdentifier, TUInt32> Dependencies;
        public List<FRigVMExternalVariable> ExternalVariables;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMGraphFunctionHeader& Data)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref LibraryPointer);
            transfer.Move(ref Name);
            transfer.Move(ref NodeTitle);
            transfer.Move(ref NodeColor);
            transfer.Move(ref Tooltip);
            transfer.Move(ref Category);
            transfer.Move(ref Keywords);
            transfer.Move(ref Arguments);
            transfer.Move(ref Dependencies);
            transfer.Move(ref ExternalVariables);
            return this;
        }
    }

    public class FRigVMFunctionCompilationData : ITransferible
    {
        public FRigVMByteCode ByteCode;
        public List<FName> FunctionNames;
        public List<FRigVMFunctionCompilationPropertyDescription> WorkPropertyDescriptions;
        public List<FRigVMFunctionCompilationPropertyPath> WorkPropertyPathDescriptions;
        public List<FRigVMFunctionCompilationPropertyDescription> LiteralPropertyDescriptions;
        public List<FRigVMFunctionCompilationPropertyPath> LiteralPropertyPathDescriptions;
        public List<FRigVMFunctionCompilationPropertyDescription> DebugPropertyDescriptions;
        public List<FRigVMFunctionCompilationPropertyPath> DebugPropertyPathDescriptions;
        public List<FRigVMFunctionCompilationPropertyDescription> ExternalPropertyDescriptions;
        public List<FRigVMFunctionCompilationPropertyPath> ExternalPropertyPathDescriptions;
        public Dictionary<TInt32, FName> ExternalRegisterIndexToVariable;
        public Dictionary<FString, FRigVMOperand> Operands;
        public UInt32 Hash;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMFunctionCompilationData& Data)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ByteCode);
            transfer.Move(ref FunctionNames);
            transfer.Move(ref WorkPropertyDescriptions);
            transfer.Move(ref WorkPropertyPathDescriptions);
            transfer.Move(ref LiteralPropertyDescriptions);
            transfer.Move(ref LiteralPropertyPathDescriptions);
            transfer.Move(ref DebugPropertyDescriptions);
            transfer.Move(ref DebugPropertyPathDescriptions);
            transfer.Move(ref ExternalPropertyDescriptions);
            transfer.Move(ref ExternalPropertyPathDescriptions);
            transfer.Move(ref ExternalRegisterIndexToVariable);
            transfer.Move(ref Operands);
            transfer.Move(ref Hash);
            return this;
        }
    }

    public class FRigVMGraphFunctionIdentifier : ITransferible
    {
        public FSoftObjectPath LibraryNode = new();
        public FSoftObjectPath HostObject = new();

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMGraphFunctionIdentifier& Data)")]
        public ITransferible Move(Transfer transfer)
        {
            LibraryNode.Move(transfer);
            HostObject.Move(transfer);
            return this;
        }
    }

    public class FRigVMGraphFunctionIdentifierJsonConverter : JsonConverter<FRigVMGraphFunctionIdentifier>
    {
        public override FRigVMGraphFunctionIdentifier Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ');
            return new FRigVMGraphFunctionIdentifier { LibraryNode = new() { Value = int.Parse(v[0]) }, HostObject = new() { Value = int.Parse(v[1]) } };
        }
        public override FRigVMGraphFunctionIdentifier ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ');
            return new FRigVMGraphFunctionIdentifier { LibraryNode = new() { Value = int.Parse(v[0]) }, HostObject = new() { Value = int.Parse(v[1]) } };
        }
        public override void Write(Utf8JsonWriter writer, FRigVMGraphFunctionIdentifier value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.LibraryNode.Value} {value.HostObject.Value}");
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FRigVMGraphFunctionIdentifier value, JsonSerializerOptions options)
        {
            writer.WritePropertyName($"{value.LibraryNode.Value} {value.HostObject.Value}");
        }
    }

    public class FRigVMGraphFunctionArgument : ITransferible
    {
        public FName Name;
        public FName DisplayName;
        public FName CPPType;
        public UInt32 CPPTypeObject;
        public FBool bIsArray;
        public ERigVMPinDirection Direction;
        public FString DefaultValue;
        public FBool bIsConst;
        public Dictionary<FString, FText> PathToTooltip;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMGraphFunctionArgument& Data)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref DisplayName);
            transfer.Move(ref CPPType);
            transfer.Move(ref CPPTypeObject);
            transfer.Move(ref bIsArray);
            Direction = (ERigVMPinDirection)transfer.Move((byte)Direction);
            transfer.Move(ref DefaultValue);
            transfer.Move(ref bIsConst);
            transfer.Move(ref PathToTooltip);
            return this;
        }
    }

    public class FRigVMFunctionCompilationPropertyDescription : ITransferible
    {
        public FName Name;
        public FString CPPType;
        public UInt32 CPPTypeObject;
        public FString DefaultValue;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref CPPType);
            transfer.Move(ref CPPTypeObject);
            transfer.Move(ref DefaultValue);
            return this;
        }
    }

    public class FRigVMFunctionCompilationPropertyPath : ITransferible
    {
        public Int32 PropertyIndex;
        public FString HeadCPPType;
        public FString SegmentPath;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMFunctionCompilationPropertyPath& Data)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref PropertyIndex);
            transfer.Move(ref HeadCPPType);
            transfer.Move(ref SegmentPath);
            return this;
        }
    }
}
