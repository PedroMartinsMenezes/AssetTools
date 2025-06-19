namespace AssetTool
{
    [JsonAsset("DataprepConsumerUserData")]
    public class UDataprepConsumerUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepContentConsumer")]
    public class UDataprepContentConsumer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}