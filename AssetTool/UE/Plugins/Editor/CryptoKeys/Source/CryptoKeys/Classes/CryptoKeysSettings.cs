namespace AssetTool
{
    [JsonAsset("CryptoKeysSettings")]
    public class UCryptoKeysSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}