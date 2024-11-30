namespace AssetTool
{
    [JsonAsset("NiagaraNodeSelect")]
    public class UNiagaraNodeSelect : UNiagaraNodeUsageSelector
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}