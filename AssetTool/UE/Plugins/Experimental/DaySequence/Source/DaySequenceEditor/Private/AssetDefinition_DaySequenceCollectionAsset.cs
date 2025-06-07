namespace AssetTool
{
    [JsonAsset("AssetDefinition_DaySequenceCollectionAsset")]
    public class UAssetDefinition_DaySequenceCollectionAsset : UAssetDefinitionDefault
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DaySequenceCollectionAssetFactory")]
    public class UDaySequenceCollectionAssetFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}