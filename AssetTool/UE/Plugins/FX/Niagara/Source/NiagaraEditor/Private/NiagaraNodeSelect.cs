namespace AssetTool
{
    [JsonAsset("NiagaraNodeSelect")]
    public class UNiagaraNodeSelect : UNiagaraNodeUsageSelector
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}