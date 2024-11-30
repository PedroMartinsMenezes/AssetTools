namespace AssetTool
{
    [JsonAsset("NiagaraNodeParameterMapBase")]
    public class UNiagaraNodeParameterMapBase : UNiagaraNodeWithDynamicPins
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}