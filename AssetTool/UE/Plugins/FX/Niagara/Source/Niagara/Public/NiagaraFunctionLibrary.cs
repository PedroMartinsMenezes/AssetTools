namespace AssetTool
{
    [JsonAsset("NiagaraFunctionLibrary")]
    public class UNiagaraFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}