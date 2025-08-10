namespace AssetTool
{
    [JsonAsset("MetaHumanGroomEditorPipeline")]
    public class UMetaHumanGroomEditorPipeline : UMetaHumanItemEditorPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}