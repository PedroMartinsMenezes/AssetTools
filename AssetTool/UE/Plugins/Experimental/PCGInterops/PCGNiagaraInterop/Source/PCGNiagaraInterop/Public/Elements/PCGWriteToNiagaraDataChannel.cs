namespace AssetTool
{
    [JsonAsset("PCGWriteToNiagaraDataChannelSettings")]
    public class UPCGWriteToNiagaraDataChannelSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}