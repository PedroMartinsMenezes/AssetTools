namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterTestPipeline")]
    public class UMetaHumanCharacterTestPipeline : UMetaHumanCollectionPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}