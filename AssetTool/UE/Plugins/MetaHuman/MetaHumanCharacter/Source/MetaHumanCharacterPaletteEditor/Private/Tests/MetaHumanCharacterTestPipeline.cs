namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterTestPipeline")]
    public class UMetaHumanCharacterTestPipeline : UMetaHumanCollectionPipeline
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}