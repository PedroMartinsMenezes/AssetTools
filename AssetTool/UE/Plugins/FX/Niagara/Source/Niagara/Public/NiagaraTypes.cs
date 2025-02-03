namespace AssetTool
{
    [TransferibleStruct("NiagaraVariable")]
    public class FNiagaraVariable : FNiagaraVariableBase
    {
        public List<byte> VarData;

        [Location("bool FNiagaraVariable::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.VariablesUseTypeDefRegistry)
            {
                transfer.Move(ref VarData);
            }
            return this;
        }
    }

    [TransferibleStruct("NiagaraVariableBase")]
    public class FNiagaraVariableBase : ITransferible
    {
        public FName Name;
        public FNiagaraTypeDefinitionHandle TypeDefHandle;

        [Location("bool FNiagaraVariableBase::Serialize(FArchive& Ar)")]
        public virtual ITransferible Move(Transfer transfer)
        {
            if (Supports.VariablesUseTypeDefRegistry)
            {
                transfer.Move(ref Name);
                transfer.Move(ref TypeDefHandle);
            }
            return this;
        }
    }

    public class FNiagaraTypeDefinitionHandle : ITransferible
    {
        public FNiagaraTypeDefinition TypeDef;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref TypeDef);
            return this;
        }
    }

    public class FNiagaraTypeDefinition : ITransferible
    {
        public UScriptStruct scriptStruct = new();
        public UInt32 ClassStructOrEnum;
        public UInt16 UnderlyingType = (UInt16)FUnderlyingType.UT_None;

        [Location("bool FNiagaraTypeDefinition::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            scriptStruct.SerializeTaggedProperties(transfer);
            return this;
        }

        public bool IsValid()
        {
            return ClassStructOrEnum != 0;
        }

        public enum FUnderlyingType : UInt16
        {
            UT_None,
            UT_Class,
            UT_Struct,
            UT_Enum
        };
    }
}