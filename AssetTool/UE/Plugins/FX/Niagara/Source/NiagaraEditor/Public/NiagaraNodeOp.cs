namespace AssetTool
{
    [JsonAsset("NiagaraNodeOp")]
    public class UNiagaraNodeOp : UNiagaraNodeWithDynamicPins
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}