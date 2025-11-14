namespace AssetTool
{
    [JsonAsset("NiagaraNodeParameterMapBase")]
    public class UNiagaraNodeParameterMapBase : UNiagaraNodeWithDynamicPins
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}