namespace AssetTool
{
    [JsonAsset("AsyncNiagaraCaptureSimCache")]
    public class UAsyncNiagaraCaptureSimCache : UCancellableAsyncAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraSimCacheFunctionLibrary")]
    public class UNiagaraSimCacheFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}