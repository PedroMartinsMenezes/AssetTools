namespace AssetTool
{
    [JsonAsset("NiagaraNodeEmitter")]
    public class UNiagaraNodeEmitter : UNiagaraNodeWithDynamicPins
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}