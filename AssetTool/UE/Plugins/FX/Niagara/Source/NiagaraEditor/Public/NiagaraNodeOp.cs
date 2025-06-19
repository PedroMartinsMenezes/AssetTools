namespace AssetTool
{
    [JsonAsset("NiagaraNodeOp")]
    public class UNiagaraNodeOp : UNiagaraNodeWithDynamicPins
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}