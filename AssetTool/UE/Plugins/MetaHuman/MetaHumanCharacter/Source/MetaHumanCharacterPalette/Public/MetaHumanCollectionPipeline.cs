namespace AssetTool
{
    [JsonAsset("MetaHumanCollectionPipeline")]
    public class UMetaHumanCollectionPipeline : UMetaHumanCharacterPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}