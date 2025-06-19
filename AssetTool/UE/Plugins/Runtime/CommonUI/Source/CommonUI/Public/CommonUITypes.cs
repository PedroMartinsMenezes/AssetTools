namespace AssetTool
{
    [JsonAsset("CommonInputMetadata")]
    public class UCommonInputMetadata : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonMappingContextMetadata")]
    public class UCommonMappingContextMetadata : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}