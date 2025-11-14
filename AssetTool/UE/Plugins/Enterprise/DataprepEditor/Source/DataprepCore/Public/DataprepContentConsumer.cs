namespace AssetTool
{
    [JsonAsset("DataprepConsumerUserData")]
    public class UDataprepConsumerUserData : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepContentConsumer")]
    public class UDataprepContentConsumer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}