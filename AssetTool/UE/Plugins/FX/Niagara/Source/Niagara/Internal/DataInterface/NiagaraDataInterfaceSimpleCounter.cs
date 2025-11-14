namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceSimpleCounter")]
    public class UNiagaraDataInterfaceSimpleCounter : UNiagaraDataInterfaceRWBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NDISimpleCounterSimCacheData")]
    public class UNDISimpleCounterSimCacheData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}