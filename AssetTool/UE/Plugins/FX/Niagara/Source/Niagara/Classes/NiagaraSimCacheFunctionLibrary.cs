namespace AssetTool
{
    [JsonAsset("AsyncNiagaraCaptureSimCache")]
    public class UAsyncNiagaraCaptureSimCache : UCancellableAsyncAction
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraSimCacheFunctionLibrary")]
    public class UNiagaraSimCacheFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}