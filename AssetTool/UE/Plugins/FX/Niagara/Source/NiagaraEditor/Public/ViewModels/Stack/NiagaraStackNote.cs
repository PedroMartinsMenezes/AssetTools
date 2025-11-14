namespace AssetTool
{
    [JsonAsset("NiagaraStackNote")]
    public class UNiagaraStackNote : UNiagaraStackEntry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}