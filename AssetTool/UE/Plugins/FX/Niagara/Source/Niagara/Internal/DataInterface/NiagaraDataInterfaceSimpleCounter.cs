namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceSimpleCounter")]
    public class UNiagaraDataInterfaceSimpleCounter : UNiagaraDataInterfaceRWBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NDISimpleCounterSimCacheData")]
    public class UNDISimpleCounterSimCacheData : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}