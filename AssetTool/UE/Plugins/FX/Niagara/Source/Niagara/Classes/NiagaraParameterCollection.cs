namespace AssetTool
{
    [JsonAsset("NiagaraParameterCollectionInstance")]
    public class UNiagaraParameterCollectionInstance : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraParameterCollection")]
    public class UNiagaraParameterCollection : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}