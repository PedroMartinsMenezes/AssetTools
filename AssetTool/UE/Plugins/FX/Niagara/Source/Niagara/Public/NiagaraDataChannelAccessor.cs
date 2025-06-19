namespace AssetTool
{
    [JsonAsset("NiagaraDataChannelReader")]
    public class UNiagaraDataChannelReader : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDataChannelWriter")]
    public class UNiagaraDataChannelWriter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}