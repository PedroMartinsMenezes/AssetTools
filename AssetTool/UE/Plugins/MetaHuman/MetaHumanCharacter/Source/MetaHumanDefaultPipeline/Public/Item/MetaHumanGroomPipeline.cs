namespace AssetTool
{
    [JsonAsset("MetaHumanGroomPipeline")]
    public class UMetaHumanGroomPipeline : UMetaHumanItemPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}