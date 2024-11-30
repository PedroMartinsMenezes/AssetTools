namespace AssetTool
{
    [JsonAsset("NiagaraNodeUsageSelector")]
    public class UNiagaraNodeUsageSelector : UNiagaraNodeWithDynamicPins
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}