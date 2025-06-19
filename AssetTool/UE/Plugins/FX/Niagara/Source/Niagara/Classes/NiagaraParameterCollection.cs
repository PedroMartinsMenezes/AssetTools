namespace AssetTool
{
    [JsonAsset("NiagaraParameterCollectionInstance")]
    public class UNiagaraParameterCollectionInstance : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraParameterCollection")]
    public class UNiagaraParameterCollection : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}