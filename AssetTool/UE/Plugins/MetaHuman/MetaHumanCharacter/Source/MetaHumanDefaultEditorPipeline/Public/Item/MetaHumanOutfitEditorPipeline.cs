namespace AssetTool
{
    [JsonAsset("MetaHumanOutfitEditorPipeline")]
    public class UMetaHumanOutfitEditorPipeline : UMetaHumanItemEditorPipeline
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}