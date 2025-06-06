namespace AssetTool
{
    [JsonAsset("NiagaraStackNote")]
    public class UNiagaraStackNote : UNiagaraStackEntry
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}