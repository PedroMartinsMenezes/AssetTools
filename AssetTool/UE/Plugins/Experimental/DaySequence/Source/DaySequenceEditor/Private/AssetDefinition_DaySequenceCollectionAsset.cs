namespace AssetTool
{
    [JsonAsset("AssetDefinition_DaySequenceCollectionAsset")]
    public class UAssetDefinition_DaySequenceCollectionAsset : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DaySequenceCollectionAssetFactory")]
    public class UDaySequenceCollectionAssetFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}