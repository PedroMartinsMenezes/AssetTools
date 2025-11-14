namespace AssetTool
{
    [JsonAsset("MetaHumanCollectionEditorPipeline")]
    public class UMetaHumanCollectionEditorPipeline : UMetaHumanCharacterEditorPipeline
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}