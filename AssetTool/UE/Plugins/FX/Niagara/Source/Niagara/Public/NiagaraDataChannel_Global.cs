namespace AssetTool
{
    [JsonAsset("NiagaraDataChannel_Global")]
    public class UNiagaraDataChannel_Global : UNiagaraDataChannel
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDataChannelHandler_Global")]
    public class UNiagaraDataChannelHandler_Global : UNiagaraDataChannelHandler
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}