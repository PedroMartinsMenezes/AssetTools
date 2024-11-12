namespace AssetTool
{
    [JsonAsset("NiagaraParameterCollectionInstance")]
    public class UNiagaraParameterCollectionInstance : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraParameterCollection")]
    public class UNiagaraParameterCollection : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}