namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceSimpleCounter")]
    public class UNiagaraDataInterfaceSimpleCounter : UNiagaraDataInterfaceRWBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NDISimpleCounterSimCacheData")]
    public class UNDISimpleCounterSimCacheData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}