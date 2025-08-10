namespace AssetTool
{
    [JsonAsset("MetaHumanDefaultPipelineBase")]
    public class UMetaHumanDefaultPipelineBase : UMetaHumanCollectionPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}