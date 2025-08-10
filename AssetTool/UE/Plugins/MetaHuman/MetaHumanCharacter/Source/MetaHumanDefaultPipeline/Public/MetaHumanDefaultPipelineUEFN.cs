namespace AssetTool
{
    [JsonAsset("MetaHumanDefaultPipelineUEFN")]
    public class UMetaHumanDefaultPipelineUEFN : UMetaHumanDefaultPipelineLegacy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}