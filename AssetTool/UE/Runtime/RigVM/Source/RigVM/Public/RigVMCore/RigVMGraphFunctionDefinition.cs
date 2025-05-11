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
            transfer.Move(ref Header);//14086707
            transfer.Move(ref CompilationData);

            if (!transfer.Supports.RigVMSaveSerializedGraphInGraphFunctionData)
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
        public FText Tooltip_DEPRECATED;
        public FString Category;
        public FString Keywords;
        public List<FRigVMGraphFunctionArgument> Arguments;
        public Dictionary<FRigVMGraphFunctionIdentifier, TUInt32> Dependencies;
        public List<FRigVMExternalVariable> ExternalVariables;
        public FRigVMVariant Variant;
        public FString Description;
        public FRigVMNodeLayout Layout;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMGraphFunctionHeader& Data)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref LibraryPointer);
            if (transfer.Supports.AddVariantToFunctionIdentifier)
            {
                transfer.Move(ref Variant);
            }
            transfer.Move(ref Name);
            transfer.Move(ref NodeTitle);
            transfer.Move(ref NodeColor);
            if (!transfer.Supports.VMRemoveTooltipFromFunctionHeader)
            {
                transfer.Move(ref Tooltip_DEPRECATED);
            }
            else
            {
                transfer.Move(ref Description);
            }
            transfer.Move(ref Category);
            transfer.Move(ref Keywords);
            transfer.Move(ref Arguments);
            transfer.Move(ref Dependencies);
            transfer.Move(ref ExternalVariables);
            if (transfer.Supports.FunctionHeaderStoresLayout)
            {
                transfer.Move(ref Layout);
            }
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
        public uint8 NumKeys;
        public List<TOperandToDebugRegisters> OperandToDebugRegisters;

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

            if (!transfer.Supports.FUE5ReleaseStreamObjectVersion_RigVMSaveDebugMapInGraphFunctionData && !transfer.Supports.FFortniteMainBranchObjectVersion_RigVMSaveDebugMapInGraphFunctionData)
            {
                return this;
            }

            transfer.Move(ref NumKeys);
            transfer.Move(ref OperandToDebugRegisters, NumKeys);

            return this;
        }

        public class TOperandToDebugRegisters : ITransferible
        {
            public FRigVMOperand Key;
            public uint8 NumValues;
            public List<FRigVMOperand> Values;

            public ITransferible Move(Transfer transfer)
            {
                transfer.Move(ref Key);
                transfer.Move(ref NumValues);
                Values = Values.Resize(transfer, NumValues);
                transfer.Move(ref Values);
                return this;
            }
        }
    }

    public class FRigVMGraphFunctionIdentifier : ITransferible
    {
        public FSoftObjectPath SoftPath = new();
        public FSoftObjectPath HostObject = new();
        public FString LibraryNodePath = new();

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMGraphFunctionIdentifier& Data)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.RemoveLibraryNodeReferenceFromFunctionIdentifier)
            {
                transfer.Move(ref SoftPath);
            }
            else
            {
                transfer.Move(ref LibraryNodePath);
            }
            transfer.Move(ref HostObject);
            return this;
        }
    }

    public class FRigVMGraphFunctionIdentifierJsonConverter : JsonConverter<FRigVMGraphFunctionIdentifier>
    {
        public override FRigVMGraphFunctionIdentifier Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(" | ");
            return new FRigVMGraphFunctionIdentifier { SoftPath = new() { Value = int.Parse(v[0]) }, HostObject = new() { Value = int.Parse(v[1]) }, LibraryNodePath = new FString(v[2]) };
        }
        public override FRigVMGraphFunctionIdentifier ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, FRigVMGraphFunctionIdentifier value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.SoftPath.Value} | {value.HostObject.Value} | {value.LibraryNodePath.Value}");
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FRigVMGraphFunctionIdentifier value, JsonSerializerOptions options)
        {
            writer.WritePropertyName($"{value.SoftPath.Value} | {value.HostObject.Value} | {value.LibraryNodePath.Value}");
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
