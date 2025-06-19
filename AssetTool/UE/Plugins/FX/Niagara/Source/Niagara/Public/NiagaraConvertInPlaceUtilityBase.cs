namespace AssetTool
{
    [JsonAsset("NiagaraConvertInPlaceUtilityBase")]
    public class UNiagaraConvertInPlaceUtilityBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}