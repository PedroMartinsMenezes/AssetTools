namespace AssetTool
{
    [JsonAsset("NiagaraNodeParameterMapBase")]
    public class UNiagaraNodeParameterMapBase : UNiagaraNodeWithDynamicPins
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}