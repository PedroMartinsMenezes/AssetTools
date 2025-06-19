namespace AssetTool
{
    [JsonAsset("NiagaraNodeIf")]
    public class UNiagaraNodeIf : UNiagaraNodeWithDynamicPins
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}