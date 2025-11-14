namespace AssetTool
{
    [JsonAsset("NiagaraNodeIf")]
    public class UNiagaraNodeIf : UNiagaraNodeWithDynamicPins
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}