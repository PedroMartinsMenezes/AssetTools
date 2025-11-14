namespace AssetTool
{
    [JsonAsset("CryptoKeysSettings")]
    public class UCryptoKeysSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}