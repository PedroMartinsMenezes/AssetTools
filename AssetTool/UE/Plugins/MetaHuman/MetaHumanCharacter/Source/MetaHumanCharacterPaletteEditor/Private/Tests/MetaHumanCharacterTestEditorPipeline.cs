namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterTestEditorPipeline")]
    public class UMetaHumanCharacterTestEditorPipeline : UMetaHumanCollectionEditorPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}