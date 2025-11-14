namespace AssetTool
{
    [JsonAsset("NiagaraNodeFunctionCall")]
    public class UNiagaraNodeFunctionCall : UNiagaraNodeWithDynamicPins
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}