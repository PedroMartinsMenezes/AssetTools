namespace AssetTool
{
    [JsonAsset("NiagaraStackFunctionInputCollection")]
    public class UNiagaraStackFunctionInputCollection : UNiagaraStackValueCollection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}