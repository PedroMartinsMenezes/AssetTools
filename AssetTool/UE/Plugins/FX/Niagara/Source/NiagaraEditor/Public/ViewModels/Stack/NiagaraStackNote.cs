namespace AssetTool
{
    [JsonAsset("NiagaraStackNote")]
    public class UNiagaraStackNote : UNiagaraStackEntry
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}