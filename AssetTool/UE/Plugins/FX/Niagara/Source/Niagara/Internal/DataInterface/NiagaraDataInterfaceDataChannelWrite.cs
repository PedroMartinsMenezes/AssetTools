namespace AssetTool
{
    [JsonAsset("NDIDataChannelWriteSimCacheData")]
    public class UNDIDataChannelWriteSimCacheData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDataInterfaceDataChannelWrite")]
    public class UNiagaraDataInterfaceDataChannelWrite : UNiagaraDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}