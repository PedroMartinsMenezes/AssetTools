namespace AssetTool
{
    [JsonAsset("MetaHumanCollectionPipeline")]
    public class UMetaHumanCollectionPipeline : UMetaHumanCharacterPipeline
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}