namespace AssetTool
{
    [JsonAsset("NiagaraStackValueCollection")]
    public class UNiagaraStackValueCollection : UNiagaraStackItemContent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}