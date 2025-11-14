namespace AssetTool
{
    [TransferableStruct("NiagaraVariable")]
    public class FNiagaraVariable : FNiagaraVariableBase
    {
        public byte[] VarData;
        public Dictionary<string, object> Tags;

        [Location("bool FNiagaraVariable::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.VariablesUseTypeDefRegistry)
            {
                transfer.Move(ref VarData);
                return this;
            }
            else
            {
                Tags ??= new();
                transfer.MoveTags(Tags, 0);
                return this;
            }
        }
    }

    [TransferableStruct("NiagaraVariableBase")]
    public class FNiagaraVariableBase : ITransferable
    {
        public FName Name;
        public FNiagaraTypeDefinitionHandle TypeDefHandle;

        [Location("bool FNiagaraVariableBase::Serialize(FArchive& Ar)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            if (transfer.Supports.VariablesUseTypeDefRegistry)
            {
                transfer.Move(ref Name);
                transfer.Move(ref TypeDefHandle);
                return this;
            }
            return default;
        }
    }

    public class FNiagaraTypeDefinitionHandle : ITransferable
    {
        public FNiagaraTypeDefinition TypeDef;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref TypeDef);
            return this;
        }
    }

    public class FNiagaraTypeDefinition : ITransferable
    {
        public UScriptStruct scriptStruct = new();
        public UInt32 ClassStructOrEnum;
        public UInt16 UnderlyingType = (UInt16)FUnderlyingType.UT_None;

        [Location("bool FNiagaraTypeDefinition::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
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