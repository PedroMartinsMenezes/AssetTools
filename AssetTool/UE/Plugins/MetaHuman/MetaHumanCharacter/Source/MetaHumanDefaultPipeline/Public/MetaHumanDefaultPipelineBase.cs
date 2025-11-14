namespace AssetTool
{
    [JsonAsset("MetaHumanDefaultPipelineBase")]
    public class UMetaHumanDefaultPipelineBase : UMetaHumanCollectionPipeline
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}