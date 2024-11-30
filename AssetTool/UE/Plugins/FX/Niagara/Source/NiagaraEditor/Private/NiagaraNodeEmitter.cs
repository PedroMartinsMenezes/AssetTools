namespace AssetTool
{
    [JsonAsset("NiagaraNodeEmitter")]
    public class UNiagaraNodeEmitter : UNiagaraNodeWithDynamicPins
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}