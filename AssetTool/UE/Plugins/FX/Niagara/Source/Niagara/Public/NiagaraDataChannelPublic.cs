namespace AssetTool
{
    [JsonAsset("NiagaraDataChannelAsset")]
    public class UNiagaraDataChannelAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [TransferableStruct("NiagaraDataChannelVariable")]
    public class FNiagaraDataChannelVariable : FNiagaraVariableBase
    {

    }
}