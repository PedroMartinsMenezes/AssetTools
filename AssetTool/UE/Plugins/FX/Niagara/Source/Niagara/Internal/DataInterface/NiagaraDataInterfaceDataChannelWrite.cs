namespace AssetTool
{
    [JsonAsset("NDIDataChannelWriteSimCacheData")]
    public class UNDIDataChannelWriteSimCacheData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDataInterfaceDataChannelWrite")]
    public class UNiagaraDataInterfaceDataChannelWrite : UNiagaraDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}