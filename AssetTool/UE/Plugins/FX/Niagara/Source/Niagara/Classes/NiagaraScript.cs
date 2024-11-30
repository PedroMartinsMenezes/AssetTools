namespace AssetTool
{
    [JsonAsset("NiagaraScript")]
    public class UNiagaraScript : UNiagaraScriptBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [TransferibleStruct("NiagaraVMExecutableData")]
    public class FNiagaraVMExecutableData : ITransferible
    {
        public UScriptStruct scriptStruct = new();

        [Location("void FNiagaraVMExecutableData::SerializeData(FArchive& Ar, bool bDDCData)")]
        public ITransferible Move(Transfer transfer)
        {
            scriptStruct.SerializeTaggedProperties(transfer);
            return this;
        }
    }
}