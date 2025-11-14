namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceMemoryBuffer")]
    public class UNiagaraDataInterfaceMemoryBuffer : UNiagaraDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NDIMemoryBufferSimCacheData")]
    public class UNDIMemoryBufferSimCacheData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}