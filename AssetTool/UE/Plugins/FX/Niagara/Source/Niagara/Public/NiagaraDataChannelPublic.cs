namespace AssetTool
{
    [JsonAsset("NiagaraDataChannelAsset")]
    public class UNiagaraDataChannelAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [TransferibleStruct("NiagaraDataChannelVariable")]
    public class FNiagaraDataChannelVariable : FNiagaraVariableBase
    {

    }
}