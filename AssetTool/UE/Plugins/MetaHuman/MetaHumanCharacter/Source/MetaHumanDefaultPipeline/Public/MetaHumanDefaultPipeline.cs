namespace AssetTool
{
    [JsonAsset("MetaHumanDefaultPipeline")]
    public class UMetaHumanDefaultPipeline : UMetaHumanDefaultPipelineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}