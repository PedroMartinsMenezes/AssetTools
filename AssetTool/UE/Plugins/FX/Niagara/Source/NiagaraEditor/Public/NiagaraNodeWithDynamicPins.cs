namespace AssetTool
{
    [JsonAsset("NiagaraNodeWithDynamicPins")]
    public class UNiagaraNodeWithDynamicPins : UNiagaraNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}