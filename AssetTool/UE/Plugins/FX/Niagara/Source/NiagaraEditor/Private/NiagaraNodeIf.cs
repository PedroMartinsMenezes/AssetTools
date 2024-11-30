namespace AssetTool
{
    [JsonAsset("NiagaraNodeIf")]
    public class UNiagaraNodeIf : UNiagaraNodeWithDynamicPins
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}