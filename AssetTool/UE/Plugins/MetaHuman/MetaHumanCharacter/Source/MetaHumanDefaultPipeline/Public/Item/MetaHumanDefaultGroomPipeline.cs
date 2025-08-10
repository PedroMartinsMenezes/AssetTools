namespace AssetTool
{
    [JsonAsset("MetaHumanDefaultGroomPipelineMaterialParameters")]
    public class UMetaHumanDefaultGroomPipelineMaterialParameters : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanDefaultGroomPipeline")]
    public class UMetaHumanDefaultGroomPipeline : UMetaHumanGroomPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}