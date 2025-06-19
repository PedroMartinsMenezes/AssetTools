namespace AssetTool
{
    [JsonAsset("NiagaraNodeUsageSelector")]
    public class UNiagaraNodeUsageSelector : UNiagaraNodeWithDynamicPins
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}