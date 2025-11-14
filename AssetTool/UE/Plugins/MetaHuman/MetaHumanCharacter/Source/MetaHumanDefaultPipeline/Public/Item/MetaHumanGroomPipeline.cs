namespace AssetTool
{
    [JsonAsset("MetaHumanGroomPipeline")]
    public class UMetaHumanGroomPipeline : UMetaHumanItemPipeline
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}