namespace AssetTool
{
    [JsonAsset("MetaHumanOutfitPipeline")]
    public class UMetaHumanOutfitPipeline : UMetaHumanItemPipeline
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}