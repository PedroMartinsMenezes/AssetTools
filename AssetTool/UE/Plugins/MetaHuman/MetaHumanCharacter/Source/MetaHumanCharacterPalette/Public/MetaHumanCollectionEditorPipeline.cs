namespace AssetTool
{
    [JsonAsset("MetaHumanCollectionEditorPipeline")]
    public class UMetaHumanCollectionEditorPipeline : UMetaHumanCharacterEditorPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}