namespace AssetTool
{
    [JsonAsset("NiagaraNodeSimTargetSelector")]
    public class UNiagaraNodeSimTargetSelector : UNiagaraNodeUsageSelector
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}