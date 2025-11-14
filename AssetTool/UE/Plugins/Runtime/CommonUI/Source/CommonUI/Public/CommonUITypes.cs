namespace AssetTool
{
    [JsonAsset("CommonInputMetadata")]
    public class UCommonInputMetadata : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonMappingContextMetadata")]
    public class UCommonMappingContextMetadata : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}