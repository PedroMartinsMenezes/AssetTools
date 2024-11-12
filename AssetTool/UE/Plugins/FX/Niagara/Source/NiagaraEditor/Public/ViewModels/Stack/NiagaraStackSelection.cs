namespace AssetTool
{
    [JsonAsset("NiagaraStackSelection")]
    public class UNiagaraStackSelection : UNiagaraStackEntry
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}