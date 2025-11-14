namespace AssetTool
{
    [JsonAsset("NiagaraDataChannel")]
    public class UNiagaraDataChannel : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDataChannelLibrary")]
    public class UNiagaraDataChannelLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}