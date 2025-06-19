namespace AssetTool
{
    [JsonAsset("NiagaraNodeFunctionCall")]
    public class UNiagaraNodeFunctionCall : UNiagaraNodeWithDynamicPins
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}