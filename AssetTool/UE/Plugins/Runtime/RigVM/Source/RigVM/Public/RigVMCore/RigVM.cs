namespace AssetTool
{
    [JsonAsset("RigVM")]
    public class URigVM : UObject
    {
        public Int32 RigVMUClassBasedStorageDefine;
        public FString ExecuteContextPath;
        public FRigVMMemoryContainer WorkMemoryStorage;
        public List<FName> FunctionNamesStorage;
        public FRigVMByteCode ByteCodeStorage;
        public List<FRigVMParameter> Parameters;
        public Dictionary<FRigVMOperand, List<FRigVMOperand>> OperandToDebugRegisters;
        public UInt32 CachedVMHash;
        public List<FRigVMPropertyPathDescription> ExternalPropertyPathDescriptions;
        public Dictionary<FString, FSoftObjectPath> UserDefinedStructGuidToPathName;
        public Dictionary<FString, FSoftObjectPath> UserDefinedEnumToPathName;
        public FRigVMMemoryStorageStruct LiteralMemoryStorage;
        public FRigVMMemoryStorageStruct DefaultWorkMemoryStorage;
        public FRigVMMemoryStorageStruct DefaultDebugMemoryStorage;

        [Location("void URigVM::Load(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            #region void URigVM::Serialize(FArchive& Ar)
            if (!transfer.Supports.StoreMarkerNamesOnSkeleton)
            {
                return this;
            }
            #endregion

            if (!transfer.Supports.FRigVMObjectVersion_BeforeCustomVersionWasAdded)
            {
                if (transfer.Supports.RigVMMemoryStorageObject)
                {
                    transfer.Move(ref RigVMUClassBasedStorageDefine);
                }
                if (!transfer.Supports.RigVMExternalExecuteContextStruct && transfer.Supports.RigVMSerializeExecuteContextStruct)
                {
                    transfer.Move(ref ExecuteContextPath);
                }
                if (RigVMUClassBasedStorageDefine == 1)
                {
                    transfer.Move(ref WorkMemoryStorage);
                    transfer.Move(ref LiteralMemoryStorage);
                    transfer.Move(ref FunctionNamesStorage);
                    transfer.Move(ref ByteCodeStorage);
                    transfer.Move(ref Parameters);
                    if (!transfer.Supports.RigVMCopyOpStoreNumBytes)
                    {
                        return this;
                    }
                    if (transfer.Supports.FUE5ReleaseStreamObjectVersion_RigVMSaveDebugMapInGraphFunctionData || transfer.Supports.FFortniteMainBranchObjectVersion_RigVMSaveDebugMapInGraphFunctionData)
                    {
                        transfer.Move(ref OperandToDebugRegisters);
                    }
                    if (transfer.Supports.VMStoringUserDefinedStructMap && transfer.Supports.HostStoringUserDefinedData)
                    {
                        transfer.Move(ref UserDefinedStructGuidToPathName);
                    }
                    if (transfer.Supports.VMStoringUserDefinedEnumMap && !transfer.Supports.HostStoringUserDefinedData)
                    {
                        transfer.Move(ref UserDefinedEnumToPathName);
                    }
                }
                if (RigVMUClassBasedStorageDefine != Consts.UE_RIGVM_UCLASS_BASED_STORAGE_DISABLED)
                {
                    return this;
                }
            }

            if (transfer.Supports.AddedVMHashChecks)
            {
                transfer.Move(ref CachedVMHash);
            }
            transfer.Move(ref ExternalPropertyPathDescriptions);
            transfer.Move(ref FunctionNamesStorage);
            transfer.Move(ref ByteCodeStorage);
            transfer.Move(ref Parameters);

            if (transfer.Supports.FUE5ReleaseStreamObjectVersion_RigVMSaveDebugMapInGraphFunctionData || transfer.Supports.FFortniteMainBranchObjectVersion_RigVMSaveDebugMapInGraphFunctionData)
            {
                transfer.Move(ref OperandToDebugRegisters);
            }
            if (transfer.Supports.VMStoringUserDefinedStructMap && !transfer.Supports.HostStoringUserDefinedData)
            {
                transfer.Move(ref UserDefinedStructGuidToPathName);
            }
            if (transfer.Supports.VMStoringUserDefinedEnumMap && !transfer.Supports.HostStoringUserDefinedData)
            {
                transfer.Move(ref UserDefinedEnumToPathName);
            }
            if (transfer.Supports.VMMemoryStorageStructSerialized)
            {
                transfer.Move(ref LiteralMemoryStorage);
            }
            if (transfer.Supports.VMMemoryStorageDefaultsGeneratedAtVM)
            {
                transfer.Move(ref DefaultWorkMemoryStorage);
                transfer.Move(ref DefaultDebugMemoryStorage);
            }

            return this;
        }
    }

    public class FRigVMParameter : ITransferable
    {
        public ERigVMParameterType Type;
        public FName Name;
        public Int32 RegisterIndex;
        public FString CPPType;
        public UInt32 ScriptStruct;

        [Location("void FRigVMParameter::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.StoreMarkerNamesOnSkeleton)
                return this;

            transfer.MoveEnum(ref Type);
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