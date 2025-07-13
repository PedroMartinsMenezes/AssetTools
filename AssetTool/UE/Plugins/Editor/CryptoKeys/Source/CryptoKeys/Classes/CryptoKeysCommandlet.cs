namespace AssetTool
{
    [JsonAsset("CryptoKeysCommandlet")]
    public class UCryptoKeysCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}