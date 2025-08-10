namespace AssetTool
{
    [JsonAsset("MetaHumanOutfitPipeline")]
    public class UMetaHumanOutfitPipeline : UMetaHumanItemPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}