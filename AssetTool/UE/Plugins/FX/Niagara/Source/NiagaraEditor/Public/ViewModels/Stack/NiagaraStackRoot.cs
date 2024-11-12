namespace AssetTool
{
    [JsonAsset("NiagaraStackRoot")]
    public class UNiagaraStackRoot : UNiagaraStackEntry
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}