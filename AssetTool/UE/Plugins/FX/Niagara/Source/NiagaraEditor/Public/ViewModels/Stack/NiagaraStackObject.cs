namespace AssetTool
{
    [JsonAsset("NiagaraStackObject")]
    public class UNiagaraStackObject : UNiagaraStackItemContent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}