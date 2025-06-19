namespace AssetTool
{
    [JsonAsset("NiagaraNodeOutputTag")]
    public class UNiagaraNodeOutputTag : UNiagaraNodeWithDynamicPins
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}