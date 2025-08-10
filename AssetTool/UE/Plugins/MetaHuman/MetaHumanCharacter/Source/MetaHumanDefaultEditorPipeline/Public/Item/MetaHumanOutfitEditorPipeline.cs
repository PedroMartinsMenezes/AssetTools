namespace AssetTool
{
    [JsonAsset("MetaHumanOutfitEditorPipeline")]
    public class UMetaHumanOutfitEditorPipeline : UMetaHumanItemEditorPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}