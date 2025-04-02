namespace AssetTool
{
    [JsonAsset("RigVM")]
    public class URigVM : UObject
    {
        public Int32 RigVMUClassBasedStorageDefine;
        public FString ExecuteContextPath;
        public FRigVMMemoryContainer WorkMemoryStorage;
        public FRigVMMemoryContainer LiteralMemoryStorage;
        public List<FName> FunctionNamesStorage;
        public FRigVMByteCode ByteCodeStorage;
        public List<FRigVMParameter> Parameters;
        public Dictionary<FRigVMOperand, List<FRigVMOperand>> OperandToDebugRegisters;
        public UInt32 CachedVMHash;
        public List<FRigVMPropertyPathDescription> ExternalPropertyPathDescriptions;

        [Location("void URigVM::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            if (!transfer.Supports.StoreMarkerNamesOnSkeleton)
                return this;

            #region void URigVM::Load(FArchive& Ar)
            if (!transfer.Supports.FRigVMObjectVersion_BeforeCustomVersionWasAdded)
            {
                if (transfer.Supports.RigVMMemoryStorageObject)
                    transfer.Move(ref RigVMUClassBasedStorageDefine);
                if (!transfer.Supports.RigVMExternalExecuteContextStruct && transfer.Supports.RigVMSerializeExecuteContextStruct)
                    transfer.Move(ref ExecuteContextPath);
                if (RigVMUClassBasedStorageDefine == 1)
                {
                    transfer.Move(ref WorkMemoryStorage);
                    transfer.Move(ref LiteralMemoryStorage);
                    transfer.Move(ref FunctionNamesStorage);
                    transfer.Move(ref ByteCodeStorage);
                    transfer.Move(ref Parameters);
                    if (!transfer.Supports.RigVMCopyOpStoreNumBytes)
                        return this;
                    if (transfer.Supports.RigVMSaveDebugMapInGraphFunctionData)
                        transfer.Move(ref OperandToDebugRegisters);
                }
                if (RigVMUClassBasedStorageDefine != Consts.UE_RIGVM_UCLASS_BASED_STORAGE_DISABLED)
                    return this;
            }

            if (transfer.Supports.AddedVMHashChecks)
            {
                transfer.Move(ref CachedVMHash);
            }
            transfer.Move(ref ExternalPropertyPathDescriptions);
            transfer.Move(ref FunctionNamesStorage);
            transfer.Move(ref ByteCodeStorage);
            transfer.Move(ref Parameters);

            if (transfer.Supports.RigVMSaveDebugMapInGraphFunctionData)
                transfer.Move(ref OperandToDebugRegisters);
            #endregion

            return this;
        }
    }

    public class FRigVMParameter : ITransferible
    {
        public ERigVMParameterType Type;
        public FName Name;
        public Int32 RegisterIndex;
        public FString CPPType;
        public UInt32 ScriptStruct;

        [Location("void FRigVMParameter::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.StoreMarkerNamesOnSkeleton)
                return this;

            Type = (ERigVMParameterType)transfer.Move((byte)Type);
            transfer.Move(ref Name);
            transfer.Move(ref RegisterIndex);
            transfer.Move(ref CPPType);
            transfer.Move(ref ScriptStruct);

            return this;
        }
    }

    public enum ERigVMParameterType : byte
    {
        Input,
        Output,
        Invalid
    }
}