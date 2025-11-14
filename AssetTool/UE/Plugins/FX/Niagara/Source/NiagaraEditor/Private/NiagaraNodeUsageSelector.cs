namespace AssetTool
{
    [JsonAsset("NiagaraNodeUsageSelector")]
    public class UNiagaraNodeUsageSelector : UNiagaraNodeWithDynamicPins
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}