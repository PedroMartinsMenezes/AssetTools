namespace AssetTool
{
    [JsonAsset("NiagaraNodeOp")]
    public class UNiagaraNodeOp : UNiagaraNodeWithDynamicPins
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}