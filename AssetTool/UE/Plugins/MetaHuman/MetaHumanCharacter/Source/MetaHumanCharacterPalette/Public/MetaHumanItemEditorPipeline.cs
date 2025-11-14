namespace AssetTool
{
    [JsonAsset("MetaHumanItemEditorPipeline")]
    public class UMetaHumanItemEditorPipeline : UMetaHumanCharacterEditorPipeline
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}