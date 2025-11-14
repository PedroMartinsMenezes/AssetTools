namespace AssetTool
{
    [JsonAsset("CryptoKeysCommandlet")]
    public class UCryptoKeysCommandlet : UCommandlet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}