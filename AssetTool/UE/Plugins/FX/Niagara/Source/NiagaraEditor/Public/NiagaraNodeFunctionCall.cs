namespace AssetTool
{
    [JsonAsset("NiagaraNodeFunctionCall")]
    public class UNiagaraNodeFunctionCall : UNiagaraNodeWithDynamicPins
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}