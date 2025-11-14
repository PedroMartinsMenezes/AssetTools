namespace AssetTool
{
    [JsonAsset("NiagaraNodeEmitter")]
    public class UNiagaraNodeEmitter : UNiagaraNodeWithDynamicPins
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}