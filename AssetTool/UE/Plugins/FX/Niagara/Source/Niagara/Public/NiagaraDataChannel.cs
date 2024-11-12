namespace AssetTool
{
    [JsonAsset("NiagaraDataChannel")]
    public class UNiagaraDataChannel : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDataChannelLibrary")]
    public class UNiagaraDataChannelLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}