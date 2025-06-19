namespace AssetTool
{
    [JsonAsset("NiagaraNodeSelect")]
    public class UNiagaraNodeSelect : UNiagaraNodeUsageSelector
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}