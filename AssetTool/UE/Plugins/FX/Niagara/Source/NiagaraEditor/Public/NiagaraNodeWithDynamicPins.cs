namespace AssetTool
{
    [JsonAsset("NiagaraNodeWithDynamicPins")]
    public class UNiagaraNodeWithDynamicPins : UNiagaraNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}