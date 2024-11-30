namespace AssetTool
{
    [JsonAsset("NiagaraNodeOutputTag")]
    public class UNiagaraNodeOutputTag : UNiagaraNodeWithDynamicPins
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}